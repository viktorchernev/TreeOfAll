using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestGadget
{
    public static class TestGadget
    {
        public static Dictionary<string, List<string>> Productions;
        public static Dictionary<string, string> Translations;
        public static Dictionary<string, string> Files;

        static TestGadget()
        {
            Translations = new Dictionary<string, string>();
            Files = new Dictionary<string, string>();
            Productions = new Dictionary<string, List<string>>();
        }



        public static void WriteTree(TreeView tree)
        {
            for (int j = 0; j < Productions["rootnode"].Count; j++)
            {
                string code = Productions["rootnode"][j];
                string text = "NULL";
                if (code != null)
                {
                    text = Translations[code];
                    var node = tree.Nodes.Add(text);
                    AddLayer(node, code);
                }
            }
        }
        static void AddLayer(TreeNode node, string code)
        {
            if (Productions.ContainsKey(code) == false) return;

            List<string> ps = Productions[code];
            for (int j = 0; j < ps.Count; j++)
            {
                string text = "NULL";
                if (ps[j] != null)
                {
                    text = Translations[ps[j]];
                    var n = node.Nodes.Add(text);
                    AddLayer(n, ps[j]);
                }
            }
        }



        public static void ParseTextFile(string filename)
        {
            string filetext = ReadTextFile(filename);
            List<string> productions = GetProductions(filetext);
            foreach (string prod in productions)
            {
                ParseProduction(prod);
            }
        }
        public static void ParseTextFiles(string path, string filename)
        {
            List<string> parsedFiles = new List<string>();

            string cur = path + filename;
            while (cur != "")
            {
                parsedFiles.Add(cur);

                string filetext = ReadTextFile(cur);
                if (filetext != null)
                {
                    List<string> productions = GetProductions(filetext);
                    foreach (string prod in productions)
                    {
                        ParseProduction(prod);
                    }
                }

                cur = "";
                foreach (string s in Files.Values)
                {
                    if (parsedFiles.Contains(path + s) == false)
                    {
                        cur = path + s;
                        break;
                    }
                }
            }
        }

        static void ParseProduction(string production)
        {
            string[] sides = production.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sides.Length; i++) sides[i] = sides[i].Trim();

            string lhs = sides[0];
            if (string.IsNullOrEmpty(lhs) || string.IsNullOrWhiteSpace(lhs)) return;

            List<string> rhs = new List<string>();
            if (sides.Length > 1)
            {
                rhs = Regex.Split(sides[1], @"(?<!($|[^\\])(\\\\)*?\\),").ToList();
                for (int i = 0; i < rhs.Count; i++)
                {
                    rhs[i] = rhs[i].Trim();
                    rhs[i] = rhs[i].Replace("\\,", ",");
                    //should use regex to match possible number of escaped escape backslashes
                }
            }

            string lcode = ParseTranslation(lhs);
            List<string> rcodes = new List<string>();
            foreach (string stat in rhs)
            {
                string rcode = ParseTranslation(stat);
                rcodes.Add(rcode);
            }
            Productions.Add(lcode, rcodes);
        }
        static string ParseTranslation(string statement)
        {
            if (!statement.Contains('<')) return null;
            if (!statement.Contains('<')) return null;

            string[] sides = statement.Split('<');
            string text = sides[0].Trim();

            string code = sides[1].Split('>')[0];
            if (code.Contains('/') && code.Length == 17)
            {
                string[] sep = code.Split('/');
                code = sep[1];
                string file = sep[0];
                if (!Files.ContainsKey(code)) Files.Add(code, file);
            }
            if (!Translations.ContainsKey(code)) Translations.Add(code, text);
            return code;
        }

        static List<string> GetProductions(string filetext)
        {
            string[] productions = filetext.Split(
                new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> li = new List<string>();
            foreach (string p in productions)
            {
                if (!string.IsNullOrEmpty(p) && !string.IsNullOrWhiteSpace(p))
                {
                    li.Add(p.Trim());
                }
            }

            return li;
        }
        static string ReadTextFile(string filename)
        {
            try
            {
                string text = File.ReadAllText(filename);
                return text;
            }
            catch
            {
                return null;
            }
        }
    }
}
