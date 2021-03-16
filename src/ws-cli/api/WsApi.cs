using nex.ws;

namespace dev.wsclient
{
    public class WSApi<TUser, TToken> : WSApiBase<TUser, TToken>
    {
        #region [ private ]
        private AuthContractWSService<TUser, TToken> _authContract;
        private BaseContractWSService<TUser, TToken> _baseContract;
        private CredentialContractWSService<TUser, TToken> _credentialContract;
        #endregion

        #region [ services ]
        public AuthContractWSService<TUser, TToken> authContract { get { return _authContract; } }
        public BaseContractWSService<TUser, TToken> baseContract { get { return _baseContract; } }
        public CredentialContractWSService<TUser, TToken> credentialContract { get { return _credentialContract; } }
        #endregion

        #region [ constructor ]
        public WSApi()
        {
            _authContract = new AuthContractWSService<TUser, TToken>(Rest, Hub);
            _baseContract = new BaseContractWSService<TUser, TToken>(Rest, Hub);
            _credentialContract = new CredentialContractWSService<TUser, TToken>(Rest, Hub);
        }
        #endregion
    }
}