 using Training;
   
Student std1=new Student(12,"Sameer kane","BCS","sameer.k@gmail.com");
Student std2=new Student(13,"Manisha Pant","BE","manisha.p@gmail.com");
Student std3=new Student(15,"Kiran Mane","MCA");
Student std4=new Student();

Console.WriteLine(std1);
Console.WriteLine(std2);
Console.WriteLine(std3);
Console.WriteLine(std4);

std1.ShowStatus();
std2.ShowStatus();
std3.ShowStatus();
std4.ShowStatus();

int noOfInstances=Student.GetCount();
Console.WriteLine("NO of objects of Student class={0}", noOfInstances);
 
 
 Console.WriteLine("hello, world");
