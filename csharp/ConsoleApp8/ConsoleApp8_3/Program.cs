/*
Задача:
Дан список объектов студентов с их именами и возрастом. 
Используя LINQ, сгруппируйте студентов по возрасту.
*/


List<Student> students = new List<Student>()
{
    new Student("Sam", 21),
    new Student("Kate", 21),
    new Student("John", 20),
    new Student("Ivan", 19),
    new Student("Sasha", 20)
};

IEnumerable<IGrouping<int, Student>> query = from student in students
                                             group student by student.Age;            

foreach(IGrouping<int, Student> key in query)
{
    Console.Write($"Key: {key.Key}\nValue:\n");
    foreach(Student student in key)
    {
        Console.WriteLine(student.ToString());
    }
    Console.WriteLine();
}


class Student
{
    public string Name;
    public int Age;

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}; age: {Age}";
    }
}