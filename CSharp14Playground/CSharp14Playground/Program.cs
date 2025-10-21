using CSharp14Playground;
using CSharp14Playground.ExtensionMembers;
using CSharp14Playground.fieldKeyword;
using CSharp14Playground.nameofUnboundGenericTypes;

PlaygroundUtils.PrintHeader("C# 14 Playground", "=");

DemoExtensionMembers.StartDemo();

DemoNameofUnboundGenericTypes.StartDemo();

DemoFieldKeyword fieldKeywordDemo = new();
fieldKeywordDemo.StartDemo();