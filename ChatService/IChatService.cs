using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ChatService
{
     [ServiceContract]
    public interface IChatService
    {

        /**
         * Ik kan alleen een berichte sturen, maar niet van wie het berichtje afkomt. 
         * Had ik maar een complex object als parameter :(
         **/ 
        [OperationContract]
        string[] SendMessage(string message);

        /**
       * Wat jammer dat ik hier alleen een lijst van string[] terug krijg.
       * Nu kan ik niet zien welk berichtje van wie is :(
       **/
        [OperationContract]
        string[] GetMessages();
    }
}