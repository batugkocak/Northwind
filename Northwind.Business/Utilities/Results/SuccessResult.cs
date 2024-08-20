namespace Northwind.Business.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) //Mesaj parametresi alıp, Result sınıfının ctor'unu çalıştırır.
        {

        }

        public SuccessResult() : base(true) // Hiç parametre almaz, Result sınıfının ctor'unu çalıştırıp true olur. 
        {

        }
    }
}
