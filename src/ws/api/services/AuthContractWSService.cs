using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using nex.ws;

namespace demo.wsclient
{
    public class AuthContractWSService<TUser, TToken>: WSServiceBase<TUser, TToken>
    {
        #region [ implement WSServiceBase ]
        public override string Name { get { return "authContract"; } }
        #endregion

        #region [ constructor ]
        public AuthContractWSService(RestClient<TUser, TToken> rest, HubClient<TUser, TToken> hub)
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

        // isAuth: true
        public HubNotificationCredentials<TUser, TToken, string> onUpdate { get { return _onUpdate; } }

        // isAuth: true
        public HubNotificationCredentialsData<TUser, TToken, string, DataType> onDataUpdate { get { return _onDataUpdate; } }
        #endregion

        #region [ rest ]

        // isAuth: true
        public Task print() { return Request( "print", null, null  ); }

        // isAuth: true
        public Task notify() { return Request( "notify", null, null  ); }
        #endregion
    }
}
