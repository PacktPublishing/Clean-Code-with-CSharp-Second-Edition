using CH09_AopWithPostSharp;

Console.WriteLine("CH09 Aop with PostSharp");

var aopTestClass = new  AopTestClass();
aopTestClass.SuccessfulMethod();
aopTestClass.FailedMethod();

Console.ReadLine();