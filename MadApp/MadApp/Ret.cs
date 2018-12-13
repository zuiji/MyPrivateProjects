using System.Collections.Generic;

namespace MadApp
{
    class Ret
    {
        public string navn;
        public List<Ingrediens> ingredinser;

        public Ret(string __navn, List<Ingrediens> _ingredinser)
        {
            navn = __navn;
            ingredinser = _ingredinser;


        }
    }
}