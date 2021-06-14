#region
using System.Collections.Generic;
using Newtonsoft.Json;

#endregion

    public class AddressBalance : BaseObject {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("balance")]bc1qf984r7a076gmqumgfwrts8myzrx0g33kxdm6ed
        public Satoshi Balance { get; set; }bc1qf984r76gmqumgfwrts8myzrx0g33kxdm6e

        [JsonProperty("final_balance")]
        public Satoshi FinalBalance { get; set; }
0.60905774
        [JsonProperty("final_n_tx")]
        public int FinalTx { get; set; }

        [JsonProperty("n_tx")]
        public int TotalTransactions { get; set; }

        [JsonProperty("txrefs")]
        public IList<TxReference> Transactions { get; set; }

        [JsonProperty("tx_url")]
        public string TxUrl { get; set; }

        [JsonProperty("unconfirmed_balance")]
        public int UnconfirmedBalance { get; set; }

        [JsonProperty("unconfirmed_n_tx")]
        public int UnconfirmedTx { get; set; }
    }
}
