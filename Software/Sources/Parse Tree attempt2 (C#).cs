using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGadget
{
    // Attribute
    public class Attribute
    {
        public string Name 
        { 
            get; 
            set; 
        }
        public string? Value
        { 
            get; 
            set; 
        }


        public Attribute(string name)
        {
            Name = name;
            Value = null;
        }
        public Attribute(string name, string val)
        {
            Name = name;
            Value = val;
        }
    }


    // Tag
    public enum TagType
    {
        Simple,
        File,
        Path,
        Namespace
    }
    public abstract class Tag
    {
        public string Id
        {
            get;
            set;
        }
        public List<Attribute> Attributes 
        { 
            get; 
            set; 
        }
        public abstract TagType Type 
        { 
            get; 
        }

        public Tag(string id)
        {
            Id = id;
            Attributes = new List<Attribute>();
        }
    }
    public class SimpleTag : Tag
    {
        public override TagType Type
        {
            get
            {
                return TagType.Simple;
            }
        }

        public SimpleTag(string id) : base(id)
        {
        }
    }
    public class FileTag : Tag
    {
        public string FileName
        {
            get;
            set;
        }
        public override TagType Type
        {
            get
            {
                return TagType.File;
            }
        }

        public FileTag(string id, string filename) : base(id)
        {
            FileName = filename;
        }
    }


    // Link
    public enum SourceCredibility
    {
        Unknown,            //U
        Questionable,       //Q
        Mundane,            //M
        Credible,           //C
        Canonical           //A
    }
    public class Link
    {
        public string Url
        {
            get;
            set;
        }
        public string? Title
        {
            get;
            set;
        }
        public SourceCredibility Credibility
        {
            get;
            set;
        }


        public Link(string url)
        {
            Url = url;
            Credibility = SourceCredibility.Unknown;
        }
        public Link(string url, string title)
        {
            Url = url;
            Title = title;
            Credibility = SourceCredibility.Unknown;
        }
        public Link(string url, string title, SourceCredibility credability)
        {
            Url = url;
            Title = title;
            Credibility = credability;
        }
    }


    // Termin/Item
    public class Termin
    {
        public string Literal
        {
            get;
            set;
        }
        public Tag Tag
        {
            get;
            set;
        }
        public List<Link> Links
        {
            get;
            set;
        }


        public Termin(string literal, Tag tag)
        {
            Literal = literal;
            Tag = tag;
            Links = new List<Link>();
        }
        public Termin(string literal, Tag tag, Link link)
        {
            Literal = literal;
            Tag = tag;
            Links = new List<Link>() { link };
        }
        public Termin(string literal, Tag tag, List<Link> links)
        {
            Literal = literal;
            Tag = tag;
            Links = links;
        }
    }


    // Productions
    public class Production
    {
        public Termin Left
        {
            get;
            set;
        }
        public List<Termin> Rights
        {
            get;
            set;
        }
        public bool IsPrimery
        {
            get;
            set;
        }

        public Production(Termin left)
        {
            Left = left;
            Rights = new List<Termin>();
            IsPrimery = false;
        }
        public Production(Termin left, List<Termin> rights)
        {
            Left = left;
            Rights = rights;
            IsPrimery = false;
        }
    }
}
