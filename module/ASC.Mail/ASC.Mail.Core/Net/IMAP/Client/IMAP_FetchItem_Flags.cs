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

namespace ASC.Mail.Net.IMAP.Client
{
    /// <summary>
    /// Specifies what data is requested from IMAP server FETCH command.
    /// Fetch items are flags and can be combined. For example: IMAP_FetchItem_Flags.MessageFlags | IMAP_FetchItem_Flags.Header.
    /// </summary>
    public enum IMAP_FetchItem_Flags
    {
        /// <summary>
        /// Message UID value.
        /// </summary>
        UID = 1,

        /// <summary>
        /// Message size in bytes.
        /// </summary>
        Size = 2,

        /// <summary>
        /// Message IMAP server INTERNALDATE.
        /// </summary>
        InternalDate = 4,

        /// <summary>
        /// Fetches message flags. (\SEEN \ANSWERED ...)
        /// </summary>
        MessageFlags = 8,

        /// <summary>
        /// Fetches message header.
        /// </summary>
        Header = 16,

        /// <summary>
        /// Fetches full message.
        /// </summary>
        Message = 32,

        /// <summary>
        /// Fetches message ENVELOPE structure.
        /// </summary>
        Envelope = 64,

        /// <summary>
        /// Fetches message BODYSTRUCTURE structure.
        /// </summary>
        BodyStructure = 128,

        /// <summary>
        /// Fetches all info.
        /// </summary>
        All = 0xFFFF
    }
}