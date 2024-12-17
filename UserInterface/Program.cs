using Stationery;

//var pencil1 = new Pencil();
//Console.WriteLine(pencil1.IsSharp);
//pencil1.Sharpen();
//Console.WriteLine(pencil1.IsSharp);

//pencil1.Write("The pencil can write");
//Console.WriteLine(pencil1.IsSharp);
//pencil1.Write("The pencil can still write");
//Console.WriteLine(pencil1.IsSharp);
//pencil1.Write("The pencil can still write");

// var ballPen = new BallPen();
// Console.WriteLine(ballPen.CanWrite);
// ballPen.Write("I am trying to write with my pen, but it is off");
// ballPen.Click();
// Console.WriteLine(ballPen.CanWrite);
// ballPen.Write("I am trying to write with my pen, and now it is on. Hurray !!");

//var redCrayon = new Crayon(ConsoleColor.Red);
//Console.WriteLine(redCrayon.IsSharp);
//redCrayon.Sharpen();
//Console.WriteLine(redCrayon.IsSharp);
//redCrayon.Write("Some text");

//var blueCrayon = new Crayon(ConsoleColor.Blue);
//blueCrayon.Sharpen();
//blueCrayon.Write("This text will be blue");

////This file needs to compile and work. To achieve this you need to implement necessary changes in the Stationery.cs file in the Utilities project

var redCrayon = new Crayon(ConsoleColor.Red);

Console.WriteLine($"The red crayon is {(redCrayon.IsSharp ? "" : "not ")}sharp");
redCrayon.Sharpen();
Console.WriteLine($"The red crayon is {(redCrayon.IsSharp ? "" : "not ")}sharp");

var blueCrayon = new Crayon(ConsoleColor.Blue);
blueCrayon.Sharpen();

var pencil = new Pencil();
pencil.Sharpen();

var ballPen = new BallPen();
ballPen.Click();

var yellowCrayon = new Crayon(ConsoleColor.Yellow);
yellowCrayon.Sharpen();

var ballPen2 = new BallPen();
ballPen2.Click();

var writableInstruments = new WritingInstrument[] { redCrayon, blueCrayon, pencil, ballPen, yellowCrayon, ballPen2 };

StationeryTester.Write("Some text", writableInstruments);
StationeryTester.Write("Some text", writableInstruments);
StationeryTester.Write("Some text", writableInstruments);
StationeryTester.Write("Some text", writableInstruments);
StationeryTester.Write("Some text", writableInstruments);

var laserPointer = new EternalLaserMarker();
laserPointer.Write("HAHAH This always work");

Sharpener.SharpenAll([redCrayon, blueCrayon, yellowCrayon, pencil ]);
StationeryTester.Write("Some text", writableInstruments);
