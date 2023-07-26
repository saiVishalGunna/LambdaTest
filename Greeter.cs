using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MyFirstTerrafromLambdaFunction;

public class Employee {
    public string firstName { get; set; }
    public string lastname { get; set; }
    public int salary { get; set; }
 }

 public class Greeter
 {
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string GreetPerson(Employee person, ILambdaContext context)
    {
        LambdaLogger.Log($"Calling: {context.FunctionName}\n");
        string s1="A1";
        if (person.salary > 500 and person.salary<=1000)
        {
            s1 = "A2";
        }
        else if (person.salary > 1000 and person.salary<=2000)
        {
            s1="A3";
        }
        else if (person.salary > 2000)
        {
            s1="A4";
        }
        else s1="A5";
        return $"Welcome: {person.firstName} {person.lastname}, your salary is {person.salary} and your job level is {s1}";
    }
 }