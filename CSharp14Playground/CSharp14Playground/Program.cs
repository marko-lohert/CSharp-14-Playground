using CSharp14Playground;
using CSharp14Playground.ExtensionMembers;
using CSharp14Playground.fieldKeyword;
using CSharp14Playground.nameofUnboundGenericTypes;
using CSharp14Playground.NullConditionalAssignment;
using CSharp14Playground.PartialEventsAndConstructors;

PlaygroundUtils.PrintHeader("C# 14 Playground", "=");

DemoExtensionMembers.StartDemo();

DemoNullConditionalAssignment.StartDemo();

DemoNameofUnboundGenericTypes.StartDemo();

DemoFieldKeyword fieldKeywordDemo = new();
fieldKeywordDemo.StartDemo();

DemoPartialEventsAndConstructors.StartDemo();