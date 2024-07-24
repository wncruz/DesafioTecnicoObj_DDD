using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafioObj.Domins.Interface
{
    public interface IPratoService
    {
        void PerguntarQualPrato(bool _primeiraVez);
        void PerguntarSeMassa(bool _primeiraVez);
        void PerguntarSeLasanha(bool _primeiraVez);
        void PerguntarSeBoloChocolate(bool _primeiraVez);
        void PerguntaEntaoQualPrato(string prato);
    }
}
