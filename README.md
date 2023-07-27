# GeometryGuru
  ### This development will help you calculate the area of a circle , triangle or square.

#### Formula:
```C#
Circle:
const double PI = Math.PI;
double radius = Convert.ToDouble(Console.ReadLine());
double area = PI * (radius * radius);
Triangle:
double heightOfTriagle = Convert.ToDouble(Console.ReadLine());
double sideOfTriagle = Convert.ToDouble(Console.ReadLine());
double areaOfTriagle = sideOfTriagle * (heightOfTriagle * heightOfTriagle);
Square:
double sideOfSquare = Convert.ToDouble(Console.ReadLine());
double areaOfSquare = sideOfSquare * sideOfSquare;
```

#### Types:
```C#
int & double & string & const
```
A *constant* is a value that remains unchanged during program execution.
#### Operators:
```C#
if(){...}
else{...}
```
The ***if-else*** construct is able to check one or more conditions, and if the condition is not true, then execute another code or check another condition.

![](./demoGeometryGuru/demoWithIf.png)

```C#
switch
```

The ***switch*** statement provides multidirctional brancing in the program.

![](./demoGeometryGuru/DemoInCodeSwitchVersion.png)

```C#
while(){...}
for(){...}
```
Loops can execute a block of code as long as a specified condition is reached.

Loops are handy because they save time, reduce errors, and they make code more readable.

The ***while*** loop loops through a block of code as long as a specified condition is True:
```C#
while (condition) 
{
  // code block to be executed
}
```

When you know exactly how many times you want to loop through a block of code, use the ***for*** loop instead of a ***while*** loop:
```C#
for (statement 1; statement 2; statement 3) 
{
  // code block to be executed
}
```

**Statement 1** is executed (one time) before the execution of the code block.

**Statement 2** defines the condition for executing the code block.

**Statement 3** is executed (every time) after the code block has been executed.

#### To understand more, look at the code  and try to run it!

#### Functions:
```C#
Output to console: Console.WriteLine();
Input from console: Console.ReadLine();
Converts: Convert.ToDouble();
```

Also in the code i used ***Escape Characters*** - replacement of control characters in the text with corresponding text substitutions.
Read more , [link](https://codebuns.com/csharp-basics/escape-sequences/).

#### Demo:

![](./demoGeometryGuru/demoall1.png)

## Release Notes
In the [second](https://github.com/ZafarUrakov/GeometryGuru/tree/releases/v2.0) version of the project , we used only arithmetic operations with ***input*** and ***output*** to the console and we also used logical operations ***if-else*** and ***switch***.

As for this version , you may notice changes in the code like:

- Loop operations have been added.
- Simplified the code.
- Fixed the errors.

Now, before you enter, the administrator will ask you.

####  You can take my code and try it yourself 👇🏻

1.About the list of files,click <> Code.

![](./demoGeometryGuru/demo1.png)


2.Copy the URL(HTTPS) of the repository.

![](./demoGeometryGuru/demo2.png)


3.Open terminal.

4.Change the current working catalogue ti the location where the cloned catalogur should be located.

5.Type "***git clone***" and paste the URL copied earlier.

![](./demoGeometryGuru/demo3.png)


6.Press enter to create a local clone.

![](./demoGeometryGuru/demo4.png)


To see other projects click [HERE](https://github.com/ZafarUrakov).