using System.Reflection;

namespace Presentation
{
    /*
     API'de controller olmayacak. Controller'ı bu katmanda oluşturacağız. Çünkü API katmanına tüm 
    katmanları refere etmek zorunda kalıyoruz.
     */
    public static class AssemblyReference
    {
        public static readonly Assembly Assembly = typeof(Assembly).Assembly;
    }
}
