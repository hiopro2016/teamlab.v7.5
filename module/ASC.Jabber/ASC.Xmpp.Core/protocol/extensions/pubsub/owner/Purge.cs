/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

namespace ASC.Xmpp.Core.protocol.extensions.pubsub.owner
{
    // Only the Namespace is different to Purge in the Event Namespace
    public class Purge : @event.Purge
    {
        #region << Constructors >>

        public Purge()
        {
            Namespace = Uri.PUBSUB_OWNER;
        }

        public Purge(string node) : this()
        {
            Node = node;
        }

        #endregion
    }
}