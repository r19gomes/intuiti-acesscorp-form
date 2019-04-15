namespace Acesscorp.Domains.Dtos
{
    public class Error
    {
        #region Properties | Fields

        public string ErrorCode { get; set; }
        public string CallStack { get; set; }
        public string ErrorMessage { get; set; }

        #endregion

        #region Builders

        public Error()
        {
        }

        public Error(string ErrorMessage, string ErrorCode, string CallStack):base()
        {
            this.ErrorCode = ErrorCode;
            this.CallStack = CallStack;
            this.ErrorMessage = ErrorMessage;
        }

        #endregion
    }
}
