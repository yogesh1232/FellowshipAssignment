using User_Registration_In_Regex;

User_Registration obj = new User_Registration();
/*if (obj.ValidateFirstName("Yogesh"))
{
    Console.WriteLine("The First Name is Valid");
}
else
    Console.WriteLine("The First Name is Invalid");*/

/*if (obj.ValidateLastName("Kusakiya"))
{
    Console.WriteLine("The Last Name is Valid");
}
else
    Console.WriteLine("The Last Name is Invalid");*/

/*if (obj.ValidateMobileNo("91 9764695852"))
{
    Console.WriteLine("The Mobile Number is Valid");
}
else
    Console.WriteLine("The Mobile Number is Invalid");*/

if (obj.ValidateEMail("abc.xyz@bl.co.in"))
{
    Console.WriteLine("The Email id is Valid");
}
else
    Console.WriteLine("The Email id is Invalid");

/*if (obj.ValidatePassword1("yogeshkusakiya"))
{
    Console.WriteLine("The password1 is Valid");
}
else
    Console.WriteLine("The password1 is Invalid");*/

/*if (obj.ValidatePassword2("Yogeshkusakiya"))
{
    Console.WriteLine("The password2 is Valid");
}
else
    Console.WriteLine("The password2 is Invalid");*/

/*if (obj.ValidatePassword3("Yogeshusakiya1"))
{
    Console.WriteLine("The password3 is Valid");
}
else
    Console.WriteLine("The password3 is Invalid");*/

/*if (obj.ValidatePassword4("Yogeshkusakiya@1234"))
{
    Console.WriteLine("The password4 is Valid");
}
else
    Console.WriteLine("The password4 is Invalid");*/


SampleEmail email = new SampleEmail();
if (email.ValidateEmail1("abc@gmail.com.com"))
{
    Console.WriteLine("The sample email is Valid");
}
else
    Console.WriteLine("The sample email is Invalid");

