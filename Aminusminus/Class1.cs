using Antlr4.Runtime;
using Aminusminus.Content;
using Aminusminus;

var fileName = "C:\\Users\\stuar\\Documents\\VISUAL STUDIO\\VSCODE\\Languages\\A--\\Aminusminus\\Content\\testing.amm"; //args 0

var fileContents = File.ReadAllText(fileName);

var inputStream = new AntlrInputStream(fileContents);
var ammLexer = new AmmLexer(inputStream);
var commonTokenStream = new CommonTokenStream(ammLexer);
var ammParser = new AmmParser(commonTokenStream);
var ammContext = ammParser.program();
var visitor = new AmmVisitor();

visitor.Visit(ammContext);