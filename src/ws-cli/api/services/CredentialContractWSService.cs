using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using nex.ws;

namespace dev.wsclient
{
    public class CredentialContractWSService<TUser, TToken>: WSServiceBase<TUser, TToken>
    {
        #region [ implement WSServiceBase ]
        public override string Name { get { return "credentialContract"; } }
        #endregion

        #region [ constructor ]
        public CredentialContractWSService(RestClient<TUser, TToken> rest, HubClient<TUser, TToken> hub)
            :base(rest, hub)
        {
            _onUpdate = new HubEvent<TUser, TToken>(hub, Name, "onUpdate");
            _onUpdateData = new HubEventData<TUser, TToken, AnyData>(hub, Name, "onUpdateData");
            _onUpdateSelection = new HubEvent<TUser, TToken>(hub, Name, "onUpdateSelection");
            _onUpdateSelectionData = new HubEventData<TUser, TToken, AnyData>(hub, Name, "onUpdateSelectionData");
            _onUpdateValidation = new HubEventValidation<TUser, TToken, double>(hub, Name, "onUpdateValidation");
            _onUpdateValidationData = new HubEventValidationData<TUser, TToken, double, AnyData>(hub, Name, "onUpdateValidationData");
            _onUpdateValidationSelection = new HubEventValidation<TUser, TToken, double>(hub, Name, "onUpdateValidationSelection");
            _onUpdateValidationSelectionData = new HubEventValidationData<TUser, TToken, double, AnyData>(hub, Name, "onUpdateValidationSelectionData");
        }
        #endregion

        #region [ hub private ]
        private HubEvent<TUser, TToken> _onUpdate { get; }
        private HubEventData<TUser, TToken, AnyData> _onUpdateData { get; }
        private HubEvent<TUser, TToken> _onUpdateSelection { get; }
        private HubEventData<TUser, TToken, AnyData> _onUpdateSelectionData { get; }
        private HubEventValidation<TUser, TToken, double> _onUpdateValidation { get; }
        private HubEventValidationData<TUser, TToken, double, AnyData> _onUpdateValidationData { get; }
        private HubEventValidation<TUser, TToken, double> _onUpdateValidationSelection { get; }
        private HubEventValidationData<TUser, TToken, double, AnyData> _onUpdateValidationSelectionData { get; }
        #endregion

        #region [ hub public ]

        // isAuth: false
        public HubEvent<TUser, TToken> onUpdate { get { return _onUpdate; } }

        // isAuth: false
        public HubEventData<TUser, TToken, AnyData> onUpdateData { get { return _onUpdateData; } }

        // isAuth: false
        public HubEvent<TUser, TToken> onUpdateSelection { get { return _onUpdateSelection; } }

        // isAuth: false
        public HubEventData<TUser, TToken, AnyData> onUpdateSelectionData { get { return _onUpdateSelectionData; } }

        // isAuth: false
        public HubEventValidation<TUser, TToken, double> onUpdateValidation { get { return _onUpdateValidation; } }

        // isAuth: false
        public HubEventValidationData<TUser, TToken, double, AnyData> onUpdateValidationData { get { return _onUpdateValidationData; } }

        // isAuth: false
        public HubEventValidation<TUser, TToken, double> onUpdateValidationSelection { get { return _onUpdateValidationSelection; } }

        // isAuth: false
        public HubEventValidationData<TUser, TToken, double, AnyData> onUpdateValidationSelectionData { get { return _onUpdateValidationSelectionData; } }
        #endregion

        #region [ rest ]

        // isAuth: false
        public Task print() { return Request( "print", null ); }

        // isAuth: false
        public Task notify() { return Request( "notify", null ); }
        #endregion
    }
}
