## What is it?
**#Describe** is a domain specific markup language, that is rendered, like HTML or wikitext. Its goal is to describe lists of items in expandable tree views. It is in an experimental phase of development, and much is changing at the moment.

## Why?
Wikipedia is a great open source database of human knowledge, and one of the most precious resources we have. It is, at least to my knowledge, as close to a universal encyclopedia as the humanity has ever gotten, so it's no wonder that Wikipedia archives end up in time capsules around the world, and on various space missions. The thing Wikipedia falls short at though, is creating a concise and robust idea about the scope of human knowledge and culture in an all-encompassing and conveniently navigable manner.
The goal of this project is to create a wiki website and other tools that can be utilized by users to create and view various different lists - from personal shopping and to-do lists to a listing of books on a topic or aspects of a scientific discipline or an industrial process, ultimately converging in something like a global index of human knowledge and culture. With regard to Wikipedia - this is not intended to act as some sort of substitution or alternative at all, but rather as a kind of extended contents page for the free encyclopedia, if you will. The #Describe markup is the language for this task, and serving as a platform will most likely be a modified version of the "MediaWiki" software.

## Where are we at the moment?
The #Describe markup should have a well-defined and tested grammar and an interpreter that can read and manipulate said grammar in order to translate the markup to data, usable in some common APIs. There should be an editor for the language with syntax highlighting and some specific features. All this should be integrated in proof of concept projects, and ultimately, in a wiki website and an app, and administration means and resources should be spun up - like a forum, IRC help channel, and various templates and guidelines that can harbor a thriving open-source community.
At the moment, the project is in a very early stage. Some grammar has been drafted, but it is highly experimental. A PoC interpreter called "Test Gadget" is operational, but in an early stage as well. "Test Gadget" is written in C# and utilizes the "Gold Parser" system. Also a PoC app is available in C# (WinForms framework) that integrates the interpreter and can be used to view actual trees of data.
Crucial next steps are: 
- to develop the grammar by adding new features and refining the syntax
- to reflect those changes in the PoC view app and the test interpreter
- to refactor the code of those PoC tools and add new features.
- to develop an editor for the markup or an add-on for an existing editor, like Notepad++

## Directory map
"Documentation\" folder contains change log files for the various related projects. Those files, apart from version history and features, also contain to-do lists and lists of items that have been done during the current iteration. 
The "Documentation\Directory map" file describes what different folders and files purpose is, much like this text does, but in greater details. 
The "Software\" folder contains all the related software projects, and is the bread and butter of this repository. Here, the plain-text and compiled forms of the language grammars can be found, as well as test files for the grammar and the "TestGadget" translator. 
The "Data\" folder contains actual lists, coded in the markup, while "Projects\" is the same but for '#Describe' projects.

## How to contribute?
The project is in a quite early stage, so there are not a lot of documentation and guidelines yet. Everyone is welcome to contribute, and the contributions are released to the public under the project's [open source license](LICENSE) - GNU General Public License version 3.0
