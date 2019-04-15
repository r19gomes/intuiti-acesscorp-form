namespace Acesscorp.Domains.Dtos.FormularioTipoDeAtributo
{
    public class FormularioTipoDeAtributoRequest : RequestBase
    {
        #region Properties | Fields

        public FormularioTipoDeAtributo FormularioTipoDeAtributo { get; set; }

        #endregion

        #region Builders

        public FormularioTipoDeAtributoRequest()
        {
            FormularioTipoDeAtributo = new FormularioTipoDeAtributo();
        }

        #endregion
    }
 }
