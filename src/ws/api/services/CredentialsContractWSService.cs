using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using nex.ws;

namespace demo.wsclient
{
    public class CredentialsContractWSService<TUser, TToken>: WSServiceBase<TUser, TToken>
    {
        #region [ implement WSServiceBase ]
        public override string Name { get { return "credentialsContract"; } }
        #endregion

        #region [ constructor ]
        public CredentialsContractWSService(RestClient<TUser, TToken> rest, HubClient<TUser, TToken> hub)
            :base(rest, hub)
        {
            _onUpdate = new HubNotificationCredentials<TUser, TToken, string>(hub, Name, "onUpdate");
            _onDataUpdate = new HubNotificationCredentialsData<TUser, TToken, string, DataType>(hub, Name, "onDataUpdate");
        }
        #endregion

        #region [ hub private ]
        private HubNotificationCredentials<TUser, TToken, string> _onUpdate { get; }
        private HubNotificationCredentialsData<TUser, TToken, string, DataType> _onDataUpdate { get; }
        #endregion

        #region [ hub public ]

        // isAuth: false
        public HubNotificationCredentials<TUser, TToken, string> onUpdate { get { return _onUpdate; } }

        // isAuth: false
        public HubNotificationCredentialsData<TUser, TToken, string, DataType> onDataUpdate { get { return _onDataUpdate; } }
        #endregion

        #region [ rest ]

        // isAuth: false
        public Task print(object credentials) { return Request( "print", null, credentials  ); }

        // isAuth: false
        public Task notify() { return Request( "notify", null, null  ); }
        #endregion
    }
}
