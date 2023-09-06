namespace TestDateFormat;

public class DateFormatterTests
{
    [Test]
    public void Test1()
    {
       string inputDate = "16/09/2023";
       string expectedOutput = "2023-09-16";

       string result = DateFormatter.ChangeFormat(inputDate);

       Assert.AreEqual(expectedOutput, result,"La conversión de la fecha no fue la esperada.");
    }

    [Test]
    public void Test2()
    {
        string inputDate = "2023-09-16";

        string result = DateFormatter.ChangeFormat(inputDate);

        Assert.AreNotEqual("2023-09-16", result,"La función no debería devolver la misma entrada sin cambios.");
    }
    //Test2 lanza la excepcion de que la fecha ingresada no esta en el formeato indicado
    
    [Test]
    public void Test3()
    {
        string inputDate = "";

        string result = DateFormatter.ChangeFormat(inputDate);

        Assert.AreEqual("",result,"La entrada en blanco no se manejó correctamente.");
    }
    //Test3 lanza la excepcion de que la decha esta vacia
}