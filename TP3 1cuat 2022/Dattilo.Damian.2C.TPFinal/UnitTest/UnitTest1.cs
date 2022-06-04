using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Persona persona = new Persona(1234, 36065992, "Damian", "Dattilo", true, 31);
        Empresa empresa = new Empresa(1234, 151515, "WASD Inc", 45);
        Cliente<Entidad> cliente = new Cliente<Entidad>(50);

        [TestMethod]
        public void IgualdadEntreEntidades()
        {

            Assert.IsTrue((Entidad)persona == (Entidad)empresa);
        }
        
        [TestMethod]
        public void AgregarALista()
        {
            Assert.IsTrue(cliente.Agregar(persona));
            Assert.IsTrue(cliente.Agregar(empresa));
        }
    }
}
