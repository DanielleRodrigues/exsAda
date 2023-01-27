class Program
{
    static void Main(string[] args)
    {
        DisplayPublicProperties();
        CreateInstance();
    }

    static void DisplayPublicProperties()
    {
        Type studentType = typeof(Student);
        PropertyInfo[] properties = studentType.GetProperties();

        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine(property.Name);
        }
    }

    static void CreateInstance()
    {
        Type studentType = typeof(Student);
        object student = Activator.CreateInstance(studentType);

        PropertyInfo nameProperty = studentType.GetProperty("Name");
        nameProperty.SetValue(student, "Danielle Rodrigues");

        PropertyInfo universityProperty = studentType.GetProperty("University");
        universityProperty.SetValue(student, "Universidade Celso Lisboa");

        PropertyInfo rollNumberProperty = studentType.GetProperty("RollNumber");
        rollNumberProperty.SetValue(student, 666666);

        MethodInfo displayInfoMethod = studentType.GetMethod("DisplayInfo");
        displayInfoMethod.Invoke(student, null);
    }
     static void Main(string[] args)
        {
            Student estudante = new Student();

            DisplayPublicProperties(estudante);

            CreateInstance();            
        }
}
