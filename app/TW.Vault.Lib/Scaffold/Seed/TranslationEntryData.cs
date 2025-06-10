using System.Collections.Generic;

namespace TW.Vault.Lib.Scaffold.Seed
{
    public static class TranslationEntryData
    {
        /*
         * Given exported CSV data:
         *
         * let csv = `...`;
         * let matcher = /(\d+),"((?:[^"]|"")+)",(\d+)/gm;
         * let entries = [];
         * while (match = matcher.exec(csv)) entries.push(match);
         * let parsedEntries = entries.map(e => ({ translationId: e[1], value: e[2].replace(/\n/g, '\\n').replace(/""/g, '\\"'), keyId: e[3] }))
         * parsedEntries.map(e => `new TranslationEntry { TranslationId = ${e.translationId}, KeyId = ${e.keyId}, Value = "${e.value}" }`).join(',\n')
         */

        public static List<TranslationEntry> Contents { get; } = new List<TranslationEntry>
        {
            new TranslationEntry { TranslationId = 1, KeyId = 2, Value = "Open Vault" },
            new TranslationEntry { TranslationId = 1, KeyId = 3, Value = "Arrival time" },
            new TranslationEntry { TranslationId = 1, KeyId = 4, Value = "Arrives in" },
            new TranslationEntry { TranslationId = 1, KeyId = 5, Value = "This script cannot be used without a premium account!" },
            new TranslationEntry { TranslationId = 1, KeyId = 6, Value = "This is your first time running the script - please see the terms and conditions on DATA COLLECTION below.\n\n\nThis script serves as an interface to the Vault, a private tool for collecting Tribal Wars data.\n\nAll data and requests to the Vault will have various information logged for security. This is limited to:\n- Authentication token\n- IP address\n- Player ID\n- Tribe ID\n- Requested endpoint\n- Time of transaction\n\nRequests to this script will only be IP-logged to protect against abuse. Information collected by this script will never be shared\nwith any third parties or any unauthorized tribes/players.\n\nThese terms can be viewed again after running the script. To cancel your agreement, do not run this script again.\n\n\nAgree to these terms?" },
            new TranslationEntry { TranslationId = 1, KeyId = 7, Value = "Thank you, please run the script again to start using it." },
            new TranslationEntry { TranslationId = 1, KeyId = 8, Value = "The script will not be ran." },
            new TranslationEntry { TranslationId = 1, KeyId = 9, Value = "The vault was recently updated, you will need to re-upload some data." },
            new TranslationEntry { TranslationId = 1, KeyId = 10, Value = "Make BB-code for back-timing" },
            new TranslationEntry { TranslationId = 1, KeyId = 11, Value = "You haven't uploaded data in a while, you can't use the backtiming script until you do. Upload your data then refresh the page and run this script again." },
            new TranslationEntry { TranslationId = 1, KeyId = 12, Value = "commands" },
            new TranslationEntry { TranslationId = 1, KeyId = 13, Value = "incomings" },
            new TranslationEntry { TranslationId = 1, KeyId = 14, Value = "reports" },
            new TranslationEntry { TranslationId = 1, KeyId = 15, Value = "troops" },
            new TranslationEntry { TranslationId = 1, KeyId = 16, Value = "You need to upload:" },
            new TranslationEntry { TranslationId = 1, KeyId = 17, Value = "An error occurred..." },
            new TranslationEntry { TranslationId = 1, KeyId = 18, Value = "No commands available" },
            new TranslationEntry { TranslationId = 1, KeyId = 19, Value = "No data is available" },
            new TranslationEntry { TranslationId = 1, KeyId = 20, Value = "Troops" },
            new TranslationEntry { TranslationId = 1, KeyId = 21, Value = "Source Village" },
            new TranslationEntry { TranslationId = 1, KeyId = 22, Value = "Launch Time" },
            new TranslationEntry { TranslationId = 1, KeyId = 23, Value = "Landing Time" },
            new TranslationEntry { TranslationId = 1, KeyId = 24, Value = "Troop Req." },
            new TranslationEntry { TranslationId = 1, KeyId = 25, Value = "Vault" },
            new TranslationEntry { TranslationId = 1, KeyId = 26, Value = "This is the Main Vault Interface. Make sure to upload your reports, etc. in the Upload tab. Run this script on your Map or on your Incomings to see everything the Vault has to offer." },
            new TranslationEntry { TranslationId = 1, KeyId = 27, Value = "Done" },
            new TranslationEntry { TranslationId = 1, KeyId = 28, Value = "Current uploads will continue running while this popup is closed." },
            new TranslationEntry { TranslationId = 1, KeyId = 29, Value = "{numIncs} incomings weren't uploaded to Vault yet and won't be tagged!" },
            new TranslationEntry { TranslationId = 1, KeyId = 30, Value = "You haven't uploaded data in a while, you can't use tagging until you do." },
            new TranslationEntry { TranslationId = 1, KeyId = 31, Value = "Note - this feature is EXPERIMENTAL and may not be accurate!" },
            new TranslationEntry { TranslationId = 1, KeyId = 32, Value = "Upload Visible Incomings" },
            new TranslationEntry { TranslationId = 1, KeyId = 33, Value = "Code" },
            new TranslationEntry { TranslationId = 1, KeyId = 34, Value = "Details" },
            new TranslationEntry { TranslationId = 1, KeyId = 35, Value = "Best known troop type (from your label or auto-calculated)" },
            new TranslationEntry { TranslationId = 1, KeyId = 36, Value = "One of: Fake, Nuke" },
            new TranslationEntry { TranslationId = 1, KeyId = 37, Value = "% of a full nuke known at the village, ie 89% or ?%" },
            new TranslationEntry { TranslationId = 1, KeyId = 38, Value = "Offensive pop known at the village, ie 19.2k or ?k" },
            new TranslationEntry { TranslationId = 1, KeyId = 39, Value = "% of a full nuke known returning to the village when this command was sent, ie 89% or ?%" },
            new TranslationEntry { TranslationId = 1, KeyId = 40, Value = "Offensive pop known returning to the village when this command was sent, ie 19.2k or ?k" },
            new TranslationEntry { TranslationId = 1, KeyId = 41, Value = "# of catapults known at the village" },
            new TranslationEntry { TranslationId = 1, KeyId = 42, Value = "# of total commands from the village to the tribe" },
            new TranslationEntry { TranslationId = 1, KeyId = 43, Value = "Name of the player that sent the attack" },
            new TranslationEntry { TranslationId = 1, KeyId = 44, Value = "Name of the village that sent the attack" },
            new TranslationEntry { TranslationId = 1, KeyId = 45, Value = "Name of the player that sent the attack" },
            new TranslationEntry { TranslationId = 1, KeyId = 46, Value = "Name of the village that sent the attack" },
            new TranslationEntry { TranslationId = 1, KeyId = 47, Value = "Coords of the village that sent the attack" },
            new TranslationEntry { TranslationId = 1, KeyId = 48, Value = "Coords of the village being attacked" },
            new TranslationEntry { TranslationId = 1, KeyId = 49, Value = "Whether the village is Offensive, Defensive, or unknown" },
            new TranslationEntry { TranslationId = 1, KeyId = 50, Value = "Custom labels you've added to the command that should be left untouched; these are surrounded by quotes ie \"Dodged\"" },
            new TranslationEntry { TranslationId = 1, KeyId = 51, Value = "Tag format:" },
            new TranslationEntry { TranslationId = 1, KeyId = 52, Value = "Reset" },
            new TranslationEntry { TranslationId = 1, KeyId = 53, Value = "Only tag unlabeled incomings" },
            new TranslationEntry { TranslationId = 1, KeyId = 54, Value = "Label as \"Fakes\" if less than" },
            new TranslationEntry { TranslationId = 1, KeyId = 55, Value = "thousand offense population" },
            new TranslationEntry { TranslationId = 1, KeyId = 56, Value = "Ignore incomings without data" },
            new TranslationEntry { TranslationId = 1, KeyId = 57, Value = "Tag All" },
            new TranslationEntry { TranslationId = 1, KeyId = 58, Value = "Tag Selected" },
            new TranslationEntry { TranslationId = 1, KeyId = 59, Value = "Revert to Old Tags" },
            new TranslationEntry { TranslationId = 1, KeyId = 60, Value = "Cancel" },
            new TranslationEntry { TranslationId = 1, KeyId = 61, Value = "Tagging will take a while!" },
            new TranslationEntry { TranslationId = 1, KeyId = 62, Value = "That's not a number!" },
            new TranslationEntry { TranslationId = 1, KeyId = 63, Value = "WARNING - Fake detection isn't 100% accurate, but you have enabled the 'label as fakes' option.\"" },
            new TranslationEntry { TranslationId = 1, KeyId = 64, Value = "You didn't select any incomings!" },
            new TranslationEntry { TranslationId = 1, KeyId = 65, Value = "Either no incomings or all tags are current" },
            new TranslationEntry { TranslationId = 1, KeyId = 66, Value = "Tagging canceled" },
            new TranslationEntry { TranslationId = 1, KeyId = 67, Value = "{numDone}/{numTotal} tagged ({numFailed} failed)" },
            new TranslationEntry { TranslationId = 1, KeyId = 68, Value = "Tagging:" },
            new TranslationEntry { TranslationId = 1, KeyId = 69, Value = "Finished:" },
            new TranslationEntry { TranslationId = 1, KeyId = 70, Value = "Canceled:" },
            new TranslationEntry { TranslationId = 1, KeyId = 71, Value = "Unknown" },
            new TranslationEntry { TranslationId = 1, KeyId = 72, Value = "Fakes" },
            new TranslationEntry { TranslationId = 1, KeyId = 73, Value = "Fake" },
            new TranslationEntry { TranslationId = 1, KeyId = 74, Value = "Nuke?" },
            new TranslationEntry { TranslationId = 1, KeyId = 75, Value = "Using Vault" },
            new TranslationEntry { TranslationId = 1, KeyId = 76, Value = "Any" },
            new TranslationEntry { TranslationId = 1, KeyId = 77, Value = "No" },
            new TranslationEntry { TranslationId = 1, KeyId = 78, Value = "You haven't uploaded data in a while, you can't use the map script until you do. Click the 'Show' link at the top of the page to start uploading. (Then refresh the page)" },
            new TranslationEntry { TranslationId = 1, KeyId = 79, Value = "# Fakes" },
            new TranslationEntry { TranslationId = 1, KeyId = 80, Value = "# Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 81, Value = "# Nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 82, Value = "# DVs" },
            new TranslationEntry { TranslationId = 1, KeyId = 83, Value = "# Players" },
            new TranslationEntry { TranslationId = 1, KeyId = 84, Value = "At home" },
            new TranslationEntry { TranslationId = 1, KeyId = 85, Value = "Stationed" },
            new TranslationEntry { TranslationId = 1, KeyId = 86, Value = "Traveling" },
            new TranslationEntry { TranslationId = 1, KeyId = 87, Value = "Owned" },
            new TranslationEntry { TranslationId = 1, KeyId = 88, Value = "Possibly recruited" },
            new TranslationEntry { TranslationId = 1, KeyId = 89, Value = "Will take ~{nukesRequired} nukes to clear at {morale}% morale (last nuke has ~{lossPercent}% losses)" },
            new TranslationEntry { TranslationId = 1, KeyId = 90, Value = "Seen at" },
            new TranslationEntry { TranslationId = 1, KeyId = 91, Value = "Latest levels" },
            new TranslationEntry { TranslationId = 1, KeyId = 92, Value = "Possible levels" },
            new TranslationEntry { TranslationId = 1, KeyId = 93, Value = "Loyalty" },
            new TranslationEntry { TranslationId = 1, KeyId = 94, Value = "Latest loyalty" },
            new TranslationEntry { TranslationId = 1, KeyId = 95, Value = "Possible loyalty" },
            new TranslationEntry { TranslationId = 1, KeyId = 96, Value = "Hover Settings" },
            new TranslationEntry { TranslationId = 1, KeyId = 97, Value = "Commands" },
            new TranslationEntry { TranslationId = 1, KeyId = 98, Value = "Possible recruits" },
            new TranslationEntry { TranslationId = 1, KeyId = 99, Value = "Buildings" },
            new TranslationEntry { TranslationId = 1, KeyId = 100, Value = "Loyalty" },
            new TranslationEntry { TranslationId = 1, KeyId = 101, Value = "Overlay Settings" },
            new TranslationEntry { TranslationId = 1, KeyId = 102, Value = "Show overlay" },
            new TranslationEntry { TranslationId = 1, KeyId = 103, Value = "Ignore intel over" },
            new TranslationEntry { TranslationId = 1, KeyId = 104, Value = "days old" },
            new TranslationEntry { TranslationId = 1, KeyId = 105, Value = "Highlights" },
            new TranslationEntry { TranslationId = 1, KeyId = 106, Value = "None" },
            new TranslationEntry { TranslationId = 1, KeyId = 107, Value = "Has group" },
            new TranslationEntry { TranslationId = 1, KeyId = 108, Value = "Has intel" },
            new TranslationEntry { TranslationId = 1, KeyId = 109, Value = "Nukes required" },
            new TranslationEntry { TranslationId = 1, KeyId = 110, Value = "Nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 111, Value = "Stacks" },
            new TranslationEntry { TranslationId = 1, KeyId = 112, Value = "Wall under level" },
            new TranslationEntry { TranslationId = 1, KeyId = 114, Value = "Returning troops over" },
            new TranslationEntry { TranslationId = 1, KeyId = 115, Value = "k pop" },
            new TranslationEntry { TranslationId = 1, KeyId = 116, Value = "Watchtower over level" },
            new TranslationEntry { TranslationId = 1, KeyId = 117, Value = "DV" },
            new TranslationEntry { TranslationId = 1, KeyId = 118, Value = "A small stack is" },
            new TranslationEntry { TranslationId = 1, KeyId = 119, Value = "and a big stack is" },
            new TranslationEntry { TranslationId = 1, KeyId = 120, Value = "Highlight villages in" },
            new TranslationEntry { TranslationId = 1, KeyId = 121, Value = "tribe" },
            new TranslationEntry { TranslationId = 1, KeyId = 122, Value = "Send Recap" },
            new TranslationEntry { TranslationId = 1, KeyId = 123, Value = "Actions/Alerts" },
            new TranslationEntry { TranslationId = 1, KeyId = 124, Value = "(No recaps)" },
            new TranslationEntry { TranslationId = 1, KeyId = 125, Value = "{duration} ago" },
            new TranslationEntry { TranslationId = 1, KeyId = 126, Value = "A list of friendly villages that were recently conquered." },
            new TranslationEntry { TranslationId = 1, KeyId = 127, Value = "Only show recaps with nobles nearby" },
            new TranslationEntry { TranslationId = 1, KeyId = 128, Value = "Village" },
            new TranslationEntry { TranslationId = 1, KeyId = 129, Value = "Loyalty" },
            new TranslationEntry { TranslationId = 1, KeyId = 130, Value = "Capped At" },
            new TranslationEntry { TranslationId = 1, KeyId = 131, Value = "Old Owner" },
            new TranslationEntry { TranslationId = 1, KeyId = 132, Value = "New Owner" },
            new TranslationEntry { TranslationId = 1, KeyId = 133, Value = "Snipes Needed" },
            new TranslationEntry { TranslationId = 1, KeyId = 134, Value = "(No snipes needed)" },
            new TranslationEntry { TranslationId = 1, KeyId = 135, Value = "A list of incoming trains that you have troops to snipe for." },
            new TranslationEntry { TranslationId = 1, KeyId = 136, Value = "# Nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 137, Value = "Lands At" },
            new TranslationEntry { TranslationId = 1, KeyId = 139, Value = "Send Stacks" },
            new TranslationEntry { TranslationId = 1, KeyId = 140, Value = "(No stacks to suggest)" },
            new TranslationEntry { TranslationId = 1, KeyId = 141, Value = "Can eat {numNukes} nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 142, Value = "A list of villages to stack, based on their incomings and current defense stationed there." },
            new TranslationEntry { TranslationId = 1, KeyId = 143, Value = "Possible Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 144, Value = "Current Stack Strength" },
            new TranslationEntry { TranslationId = 1, KeyId = 145, Value = "Noble Targets" },
            new TranslationEntry { TranslationId = 1, KeyId = 146, Value = "(No suggested targets)" },
            new TranslationEntry { TranslationId = 1, KeyId = 147, Value = "{duration} ago" },
            new TranslationEntry { TranslationId = 1, KeyId = 148, Value = "A list of potential nobling targets, based on their stationed defense and current loyalty." },
            new TranslationEntry { TranslationId = 1, KeyId = 149, Value = "Stationed DVs" },
            new TranslationEntry { TranslationId = 1, KeyId = 150, Value = "DVs Seen At" },
            new TranslationEntry { TranslationId = 1, KeyId = 151, Value = "Owner" },
            new TranslationEntry { TranslationId = 1, KeyId = 152, Value = "Useless Stacks" },
            new TranslationEntry { TranslationId = 1, KeyId = 153, Value = "(No useless stacks)" },
            new TranslationEntry { TranslationId = 1, KeyId = 154, Value = "A list of villages that should have their support sent home, whether they are backline villages or non-friendly villages." },
            new TranslationEntry { TranslationId = 1, KeyId = 155, Value = "Tribe" },
            new TranslationEntry { TranslationId = 1, KeyId = 156, Value = "Pop. Count" },
            new TranslationEntry { TranslationId = 1, KeyId = 157, Value = "Quick Support" },
            new TranslationEntry { TranslationId = 1, KeyId = 158, Value = "No players found!" },
            new TranslationEntry { TranslationId = 1, KeyId = 159, Value = "Find and mail players with nearby defense." },
            new TranslationEntry { TranslationId = 1, KeyId = 160, Value = "Send to" },
            new TranslationEntry { TranslationId = 1, KeyId = 161, Value = "that can reach within" },
            new TranslationEntry { TranslationId = 1, KeyId = 162, Value = "hours" },
            new TranslationEntry { TranslationId = 1, KeyId = 163, Value = "Search" },
            new TranslationEntry { TranslationId = 1, KeyId = 164, Value = "Results" },
            new TranslationEntry { TranslationId = 1, KeyId = 165, Value = "Request Stack" },
            new TranslationEntry { TranslationId = 1, KeyId = 166, Value = "Find and mail players with backline defense." },
            new TranslationEntry { TranslationId = 1, KeyId = 167, Value = "Send to" },
            new TranslationEntry { TranslationId = 1, KeyId = 168, Value = "that can reach within" },
            new TranslationEntry { TranslationId = 1, KeyId = 169, Value = "hours (optional)" },
            new TranslationEntry { TranslationId = 1, KeyId = 170, Value = "Admin" },
            new TranslationEntry { TranslationId = 1, KeyId = 171, Value = "Delete" },
            new TranslationEntry { TranslationId = 1, KeyId = 172, Value = "{tribeName} will no longer be considered an enemy." },
            new TranslationEntry { TranslationId = 1, KeyId = 173, Value = "Enemy Tribes" },
            new TranslationEntry { TranslationId = 1, KeyId = 174, Value = "An error occurred while listing enemy tribes..." },
            new TranslationEntry { TranslationId = 1, KeyId = 175, Value = "Enter the name or tag of the tribe." },
            new TranslationEntry { TranslationId = 1, KeyId = 176, Value = "No tribe exists with that tag or name." },
            new TranslationEntry { TranslationId = 1, KeyId = 177, Value = "That tribe is already registered as an enemy." },
            new TranslationEntry { TranslationId = 1, KeyId = 178, Value = "Enemy Tribes" },
            new TranslationEntry { TranslationId = 1, KeyId = 179, Value = "Tell the Vault which tribes to consider as \"enemies\" when determining which villages are back-line." },
            new TranslationEntry { TranslationId = 1, KeyId = 180, Value = "Add Enemy Tribe" },
            new TranslationEntry { TranslationId = 1, KeyId = 181, Value = "Manage Users" },
            new TranslationEntry { TranslationId = 1, KeyId = 182, Value = "Keys" },
            new TranslationEntry { TranslationId = 1, KeyId = 183, Value = "Make new key" },
            new TranslationEntry { TranslationId = 1, KeyId = 184, Value = "New Vault Script" },
            new TranslationEntry { TranslationId = 1, KeyId = 185, Value = "User name" },
            new TranslationEntry { TranslationId = 1, KeyId = 186, Value = "Current tribe" },
            new TranslationEntry { TranslationId = 1, KeyId = 187, Value = "Tribe Stats" },
            new TranslationEntry { TranslationId = 1, KeyId = 188, Value = "Working" },
            new TranslationEntry { TranslationId = 1, KeyId = 189, Value = "Get tribe army stats as a spreadsheet:" },
            new TranslationEntry { TranslationId = 1, KeyId = 190, Value = "Include stats for 1/4, 1/2, and 3/4 nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 191, Value = "Download" },
            new TranslationEntry { TranslationId = 1, KeyId = 192, Value = "Log" },
            new TranslationEntry { TranslationId = 1, KeyId = 193, Value = "User Log" },
            new TranslationEntry { TranslationId = 1, KeyId = 194, Value = "Admin" },
            new TranslationEntry { TranslationId = 1, KeyId = 195, Value = "Event" },
            new TranslationEntry { TranslationId = 1, KeyId = 196, Value = "Time" },
            new TranslationEntry { TranslationId = 1, KeyId = 197, Value = "Enter the username or ID" },
            new TranslationEntry { TranslationId = 1, KeyId = 198, Value = "No tribe" },
            new TranslationEntry { TranslationId = 1, KeyId = 199, Value = "Make admin" },
            new TranslationEntry { TranslationId = 1, KeyId = 200, Value = "Revoke admin" },
            new TranslationEntry { TranslationId = 1, KeyId = 201, Value = "Get script" },
            new TranslationEntry { TranslationId = 1, KeyId = 202, Value = "{playerName} will have their Vault key removed." },
            new TranslationEntry { TranslationId = 1, KeyId = 203, Value = "{playerName} will no longer have admin privileges." },
            new TranslationEntry { TranslationId = 1, KeyId = 204, Value = "{playerName} will be given admin privileges, and will be able to:\n- Access all troop information available\n- Add new users\n- Give and revoke admin privileges for users" },
            new TranslationEntry { TranslationId = 1, KeyId = 205, Value = "Vault script for: {playerName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 206, Value = "1/4 Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 207, Value = "1/2 Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 208, Value = "3/4 Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 209, Value = "Total Full Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 210, Value = "Total Nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 211, Value = "Total Possible Nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 212, Value = "Total DVs" },
            new TranslationEntry { TranslationId = 1, KeyId = 213, Value = "Total Incs" },
            new TranslationEntry { TranslationId = 1, KeyId = 214, Value = "Total Attacks" },
            new TranslationEntry { TranslationId = 1, KeyId = 215, Value = "Needs upload?" },
            new TranslationEntry { TranslationId = 1, KeyId = 216, Value = "Yes" },
            new TranslationEntry { TranslationId = 1, KeyId = 217, Value = "Player" },
            new TranslationEntry { TranslationId = 1, KeyId = 218, Value = "Full Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 219, Value = "Nukes Traveling" },
            new TranslationEntry { TranslationId = 1, KeyId = 220, Value = "Possible nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 221, Value = "Owned DVs" },
            new TranslationEntry { TranslationId = 1, KeyId = 222, Value = "DVs at Home" },
            new TranslationEntry { TranslationId = 1, KeyId = 223, Value = "Backline DVs at Home" },
            new TranslationEntry { TranslationId = 1, KeyId = 224, Value = "DVs Traveling" },
            new TranslationEntry { TranslationId = 1, KeyId = 225, Value = "DVs Supporting Self" },
            new TranslationEntry { TranslationId = 1, KeyId = 226, Value = "DVs Supporting Others" },
            new TranslationEntry { TranslationId = 1, KeyId = 227, Value = "Est. Off. Villas" },
            new TranslationEntry { TranslationId = 1, KeyId = 228, Value = "Est. Def. Villas" },
            new TranslationEntry { TranslationId = 1, KeyId = 229, Value = "# Incs" },
            new TranslationEntry { TranslationId = 1, KeyId = 230, Value = "# Attacks" },
            new TranslationEntry { TranslationId = 1, KeyId = 231, Value = "DVs to {tribeName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 234, Value = "Notifications" },
            new TranslationEntry { TranslationId = 1, KeyId = 241, Value = "Server Time" },
            new TranslationEntry { TranslationId = 1, KeyId = 243, Value = "Message" },
            new TranslationEntry { TranslationId = 1, KeyId = 244, Value = "Add" },
            new TranslationEntry { TranslationId = 1, KeyId = 264, Value = "Optional" },
            new TranslationEntry { TranslationId = 1, KeyId = 268, Value = "Save" },
            new TranslationEntry { TranslationId = 1, KeyId = 275, Value = "Stats" },
            new TranslationEntry { TranslationId = 1, KeyId = 282, Value = "Me" },
            new TranslationEntry { TranslationId = 1, KeyId = 283, Value = "An error occurred while loading stats" },
            new TranslationEntry { TranslationId = 1, KeyId = 284, Value = "Last 7 Days" },
            new TranslationEntry { TranslationId = 1, KeyId = 285, Value = "Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 286, Value = "Fangs" },
            new TranslationEntry { TranslationId = 1, KeyId = 287, Value = "Support" },
            new TranslationEntry { TranslationId = 1, KeyId = 288, Value = "Defense" },
            new TranslationEntry { TranslationId = 1, KeyId = 289, Value = "# DVs" },
            new TranslationEntry { TranslationId = 1, KeyId = 290, Value = "At Home" },
            new TranslationEntry { TranslationId = 1, KeyId = 291, Value = "(Backline) At Home" },
            new TranslationEntry { TranslationId = 1, KeyId = 292, Value = "Traveling" },
            new TranslationEntry { TranslationId = 1, KeyId = 293, Value = "Support" },
            new TranslationEntry { TranslationId = 1, KeyId = 294, Value = "High Scores" },
            new TranslationEntry { TranslationId = 1, KeyId = 295, Value = "An error occurred while getting rankings" },
            new TranslationEntry { TranslationId = 1, KeyId = 296, Value = "Rankings" },
            new TranslationEntry { TranslationId = 1, KeyId = 297, Value = "Support" },
            new TranslationEntry { TranslationId = 1, KeyId = 298, Value = "Disclaimers and Terms" },
            new TranslationEntry { TranslationId = 1, KeyId = 299, Value = "This tool is not endorsed or developed by InnoGames." },
            new TranslationEntry { TranslationId = 1, KeyId = 300, Value = "All data and requests to the Vault will have various information logged for security. This is limited to:\n\nAuthentication token, IP address, player ID, tribe ID, requested endpoint, and time of transaction.\n\nRequests to this script will only be IP-logged to protect against abuse. Information collected by this script will never be shared with any third parties or any unauthorized tribes/players." },
            new TranslationEntry { TranslationId = 1, KeyId = 301, Value = "Tools" },
            new TranslationEntry { TranslationId = 1, KeyId = 302, Value = "Fake Script" },
            new TranslationEntry { TranslationId = 1, KeyId = 303, Value = "Dynamic Fake Scripts" },
            new TranslationEntry { TranslationId = 1, KeyId = 304, Value = "Players" },
            new TranslationEntry { TranslationId = 1, KeyId = 305, Value = "Tribes" },
            new TranslationEntry { TranslationId = 1, KeyId = 306, Value = "Continents" },
            new TranslationEntry { TranslationId = 1, KeyId = 307, Value = "Min Coord" },
            new TranslationEntry { TranslationId = 1, KeyId = 308, Value = "Max Coord" },
            new TranslationEntry { TranslationId = 1, KeyId = 310, Value = "Dist From Center" },
            new TranslationEntry { TranslationId = 1, KeyId = 311, Value = "fields from" },
            new TranslationEntry { TranslationId = 1, KeyId = 312, Value = "Get Coords" },
            new TranslationEntry { TranslationId = 1, KeyId = 314, Value = "Found {numTimings} timings for {numNukes} returning nukes ({numShown} shown)" },
            new TranslationEntry { TranslationId = 1, KeyId = 315, Value = "Find Backtimes" },
            new TranslationEntry { TranslationId = 1, KeyId = 316, Value = "Working... (This may take a while)" },
            new TranslationEntry { TranslationId = 1, KeyId = 318, Value = "Get plans for all available backtimes that you can make for enemy nukes using the troops you've uploaded to the vault." },
            new TranslationEntry { TranslationId = 1, KeyId = 319, Value = "Upload your troops frequently to get the most accurate timings!" },
            new TranslationEntry { TranslationId = 1, KeyId = 320, Value = "Minimum returning population:" },
            new TranslationEntry { TranslationId = 1, KeyId = 321, Value = "Minimum attack size:" },
            new TranslationEntry { TranslationId = 1, KeyId = 322, Value = "% of a full nuke" },
            new TranslationEntry { TranslationId = 1, KeyId = 323, Value = "Max travel time:" },
            new TranslationEntry { TranslationId = 1, KeyId = 324, Value = "Max number of timings:" },
            new TranslationEntry { TranslationId = 1, KeyId = 325, Value = "Hide backtimed nukes:" },
            new TranslationEntry { TranslationId = 1, KeyId = 326, Value = "Hide stacked nukes:" },
            new TranslationEntry { TranslationId = 1, KeyId = 327, Value = "Upload" },
            new TranslationEntry { TranslationId = 1, KeyId = 328, Value = "Uploads all data from all new battle reports." },
            new TranslationEntry { TranslationId = 1, KeyId = 329, Value = "Uploads all available data from your Incomings page. This includes attacks and support." },
            new TranslationEntry { TranslationId = 1, KeyId = 330, Value = "Uploads all data for all of your current commands." },
            new TranslationEntry { TranslationId = 1, KeyId = 331, Value = "Uploads all data for all troops." },
            new TranslationEntry { TranslationId = 1, KeyId = 332, Value = "Local vault cache cleared." },
            new TranslationEntry { TranslationId = 1, KeyId = 333, Value = "Waiting" },
            new TranslationEntry { TranslationId = 1, KeyId = 334, Value = "An unexpected error occurred:" },
            new TranslationEntry { TranslationId = 1, KeyId = 335, Value = "Upload" },
            new TranslationEntry { TranslationId = 1, KeyId = 336, Value = "Progress" },
            new TranslationEntry { TranslationId = 1, KeyId = 340, Value = "Details" },
            new TranslationEntry { TranslationId = 1, KeyId = 341, Value = "Click \"Upload All\" below. If needed, upload different things individually using the other Upload buttons." },
            new TranslationEntry { TranslationId = 1, KeyId = 342, Value = "Reports" },
            new TranslationEntry { TranslationId = 1, KeyId = 345, Value = "Incomings" },
            new TranslationEntry { TranslationId = 1, KeyId = 347, Value = "Commands" },
            new TranslationEntry { TranslationId = 1, KeyId = 348, Value = "Upload All" },
            new TranslationEntry { TranslationId = 1, KeyId = 349, Value = "Clear Cache" },
            new TranslationEntry { TranslationId = 1, KeyId = 356, Value = "Collecting command pages..." },
            new TranslationEntry { TranslationId = 1, KeyId = 357, Value = "Finished: No new commands to upload." },
            new TranslationEntry { TranslationId = 1, KeyId = 358, Value = "Checking for previously-uploaded commands..." },
            new TranslationEntry { TranslationId = 1, KeyId = 359, Value = "Uploading commands..." },
            new TranslationEntry { TranslationId = 1, KeyId = 360, Value = "Finished: {numDone}/{numTotal} uploaded, {numFailed} failed." },
            new TranslationEntry { TranslationId = 1, KeyId = 361, Value = "Failed to check for old commands, uploading all..." },
            new TranslationEntry { TranslationId = 1, KeyId = 362, Value = "Found {numCommands} old commands, skipping these..." },
            new TranslationEntry { TranslationId = 1, KeyId = 363, Value = "{numDone}/{numTotal} done, {numFailed} failed" },
            new TranslationEntry { TranslationId = 1, KeyId = 364, Value = "Collecting incoming pages..." },
            new TranslationEntry { TranslationId = 1, KeyId = 365, Value = "({numDone}/{numTotal} done, {numFailed} failed)" },
            new TranslationEntry { TranslationId = 1, KeyId = 366, Value = "Uploading incomings..." },
            new TranslationEntry { TranslationId = 1, KeyId = 367, Value = "Finished: Uploaded {numIncomings} incomings." },
            new TranslationEntry { TranslationId = 1, KeyId = 368, Value = "Collecting report pages..." },
            new TranslationEntry { TranslationId = 1, KeyId = 369, Value = "Collecting report links..." },
            new TranslationEntry { TranslationId = 1, KeyId = 370, Value = "Collecting reports pages... (page {numDone}/{numTotal})" },
            new TranslationEntry { TranslationId = 1, KeyId = 371, Value = "Checking for reports already uploaded..." },
            new TranslationEntry { TranslationId = 1, KeyId = 372, Value = "Couldn't find Loot Assistant reports folder, skipping filtering..." },
            new TranslationEntry { TranslationId = 1, KeyId = 373, Value = "Loot Assistant" },
            new TranslationEntry { TranslationId = 1, KeyId = 374, Value = "Filtering loot assistant reports..." },
            new TranslationEntry { TranslationId = 1, KeyId = 375, Value = "Error getting Loot Assistant reports folder, skipping filtering..." },
            new TranslationEntry { TranslationId = 1, KeyId = 376, Value = "Found {numOld} previously uploaded reports, skipping these..." },
            new TranslationEntry { TranslationId = 1, KeyId = 377, Value = "An error occurred while checking for existing reports, continuing..." },
            new TranslationEntry { TranslationId = 1, KeyId = 378, Value = "Finished: {numDone}/{numTotal} uploaded, {numFailed} failed." },
            new TranslationEntry { TranslationId = 1, KeyId = 379, Value = "Finished: No new reports to upload." },
            new TranslationEntry { TranslationId = 1, KeyId = 380, Value = "Uploading {numTotal} reports... ({numDone} done, {numFailed} failed.)" },
            new TranslationEntry { TranslationId = 1, KeyId = 381, Value = "Getting village troop pages..." },
            new TranslationEntry { TranslationId = 1, KeyId = 382, Value = "Finding village with academy..." },
            new TranslationEntry { TranslationId = 1, KeyId = 383, Value = "(No village with academy found)" },
            new TranslationEntry { TranslationId = 1, KeyId = 384, Value = "Getting possible nobles..." },
            new TranslationEntry { TranslationId = 1, KeyId = 385, Value = "Getting support..." },
            new TranslationEntry { TranslationId = 1, KeyId = 386, Value = "Collecting supported villages and DVs..." },
            new TranslationEntry { TranslationId = 1, KeyId = 387, Value = "An error occurred while finding villa with academy..." },
            new TranslationEntry { TranslationId = 1, KeyId = 388, Value = "Noblemen limit:{numNobles}" },
            new TranslationEntry { TranslationId = 1, KeyId = 389, Value = "Number of conquered villages:{numVillages}" },
            new TranslationEntry { TranslationId = 1, KeyId = 390, Value = "An error occurred while getting possible noble counts..." },
            new TranslationEntry { TranslationId = 1, KeyId = 391, Value = "Uploading troops to vault..." },
            new TranslationEntry { TranslationId = 1, KeyId = 392, Value = "An error occurred while uploading to the vault." },
            new TranslationEntry { TranslationId = 1, KeyId = 393, Value = "Finished: Uploaded troops for {numVillages} villages." },
            new TranslationEntry { TranslationId = 1, KeyId = 394, Value = "Uploading support to vault..." },
            new TranslationEntry { TranslationId = 1, KeyId = 395, Value = "Ram" },
            new TranslationEntry { TranslationId = 1, KeyId = 396, Value = "ram, rams" },
            new TranslationEntry { TranslationId = 1, KeyId = 397, Value = "Catapult" },
            new TranslationEntry { TranslationId = 1, KeyId = 398, Value = "catapult, cat, cats" },
            new TranslationEntry { TranslationId = 1, KeyId = 399, Value = "Spear" },
            new TranslationEntry { TranslationId = 1, KeyId = 400, Value = "spear, spears, sp" },
            new TranslationEntry { TranslationId = 1, KeyId = 401, Value = "Sword" },
            new TranslationEntry { TranslationId = 1, KeyId = 402, Value = "sword, swords, sw" },
            new TranslationEntry { TranslationId = 1, KeyId = 403, Value = "Axe" },
            new TranslationEntry { TranslationId = 1, KeyId = 404, Value = "axe" },
            new TranslationEntry { TranslationId = 1, KeyId = 405, Value = "Archer" },
            new TranslationEntry { TranslationId = 1, KeyId = 406, Value = "archer, ar" },
            new TranslationEntry { TranslationId = 1, KeyId = 407, Value = "Scout" },
            new TranslationEntry { TranslationId = 1, KeyId = 408, Value = "scout, scouts, sc" },
            new TranslationEntry { TranslationId = 1, KeyId = 409, Value = "Light Cav." },
            new TranslationEntry { TranslationId = 1, KeyId = 410, Value = "light cav, light cavalry, light, lc" },
            new TranslationEntry { TranslationId = 1, KeyId = 411, Value = "Mounted Ar." },
            new TranslationEntry { TranslationId = 1, KeyId = 412, Value = "mounted ar, mounted archer, marcher, ma" },
            new TranslationEntry { TranslationId = 1, KeyId = 413, Value = "Heavy Cav." },
            new TranslationEntry { TranslationId = 1, KeyId = 414, Value = "heavy cav, heavy cavalry, hc, heavy" },
            new TranslationEntry { TranslationId = 1, KeyId = 415, Value = "Paladin" },
            new TranslationEntry { TranslationId = 1, KeyId = 416, Value = "paladin, pally" },
            new TranslationEntry { TranslationId = 1, KeyId = 417, Value = "Headquarters" },
            new TranslationEntry { TranslationId = 1, KeyId = 418, Value = "Barracks" },
            new TranslationEntry { TranslationId = 1, KeyId = 419, Value = "Stable" },
            new TranslationEntry { TranslationId = 1, KeyId = 420, Value = "Workshop" },
            new TranslationEntry { TranslationId = 1, KeyId = 421, Value = "Academy" },
            new TranslationEntry { TranslationId = 1, KeyId = 422, Value = "Smithy" },
            new TranslationEntry { TranslationId = 1, KeyId = 423, Value = "Rally point" },
            new TranslationEntry { TranslationId = 1, KeyId = 424, Value = "Statue" },
            new TranslationEntry { TranslationId = 1, KeyId = 425, Value = "Market" },
            new TranslationEntry { TranslationId = 1, KeyId = 426, Value = "Timber camp" },
            new TranslationEntry { TranslationId = 1, KeyId = 427, Value = "Clay pit" },
            new TranslationEntry { TranslationId = 1, KeyId = 428, Value = "Iron mine" },
            new TranslationEntry { TranslationId = 1, KeyId = 429, Value = "Farm" },
            new TranslationEntry { TranslationId = 1, KeyId = 430, Value = "Warehouse" },
            new TranslationEntry { TranslationId = 1, KeyId = 431, Value = "Hiding place" },
            new TranslationEntry { TranslationId = 1, KeyId = 432, Value = "Wall" },
            new TranslationEntry { TranslationId = 1, KeyId = 433, Value = "Watchtower" },
            new TranslationEntry { TranslationId = 1, KeyId = 434, Value = "Church" },
            new TranslationEntry { TranslationId = 1, KeyId = 435, Value = "from {oldLoyalty} to {newLoyalty}" },
            new TranslationEntry { TranslationId = 1, KeyId = 438, Value = "table" },
            new TranslationEntry { TranslationId = 1, KeyId = 439, Value = "Tribal wars Captcha was triggered, please refresh the page and try again. Any uploads will continue where they left off." },
            new TranslationEntry { TranslationId = 1, KeyId = 440, Value = "Your current village group isn't \"All\", please change to group \"All\"." },
            new TranslationEntry { TranslationId = 1, KeyId = 441, Value = "You have filters set for your {dataType}, please remove them before uploading." },
            new TranslationEntry { TranslationId = 1, KeyId = 448, Value = "jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec" },
            new TranslationEntry { TranslationId = 1, KeyId = 449, Value = "today at {time}" },
            new TranslationEntry { TranslationId = 1, KeyId = 450, Value = "tomorrow at {time}" },
            new TranslationEntry { TranslationId = 1, KeyId = 451, Value = "{time} on {date}" },
            new TranslationEntry { TranslationId = 1, KeyId = 452, Value = "on {date} at {time}" },
            new TranslationEntry { TranslationId = 1, KeyId = 453, Value = "{hour}:{minute}:{second}:{millisecond} on {day}:{month}:{year}" },
            new TranslationEntry { TranslationId = 1, KeyId = 454, Value = "day" },
            new TranslationEntry { TranslationId = 1, KeyId = 455, Value = "hr" },
            new TranslationEntry { TranslationId = 1, KeyId = 456, Value = "min" },
            new TranslationEntry { TranslationId = 1, KeyId = 457, Value = "sec" },
            new TranslationEntry { TranslationId = 1, KeyId = 458, Value = "days" },
            new TranslationEntry { TranslationId = 1, KeyId = 459, Value = "hrs" },
            new TranslationEntry { TranslationId = 1, KeyId = 460, Value = "mins" },
            new TranslationEntry { TranslationId = 1, KeyId = 461, Value = "secs" },
            new TranslationEntry { TranslationId = 1, KeyId = 462, Value = "{numDone}/{numTotal} done, {numFailed} failed" },
            new TranslationEntry { TranslationId = 1, KeyId = 463, Value = "Added key for {playerName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 464, Value = "Revoked admin privileges for {playerName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 465, Value = "Gave admin privileges to {playerName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 466, Value = "Re-enabled key for {playerName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 467, Value = "Disabled key for {playerName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 468, Value = "Changed key owner from {oldPlayer} to {newPlayer}" },
            new TranslationEntry { TranslationId = 1, KeyId = 469, Value = "Set key for {playerName} as read-only" },
            new TranslationEntry { TranslationId = 1, KeyId = 470, Value = "Key for {playerName} no longer read-only" },
            new TranslationEntry { TranslationId = 1, KeyId = 471, Value = "Changed server assigned for {playerName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 472, Value = "Cleared administrator of {playerName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 473, Value = "{adminName} gave admin privileges to {playerName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 474, Value = "Changed administrator of {playerName} from {oldAdmin} to {newAdmin}" },
            new TranslationEntry { TranslationId = 1, KeyId = 475, Value = "Updated {playerName} (unknown change)" },
            new TranslationEntry { TranslationId = 1, KeyId = 476, Value = "Deleted key for {playerName}" },
            new TranslationEntry { TranslationId = 1, KeyId = 477, Value = "No player could be found with the given player ID." },
            new TranslationEntry { TranslationId = 1, KeyId = 478, Value = "No user could be found with the given name." },
            new TranslationEntry { TranslationId = 1, KeyId = 479, Value = "Either the player ID or player name must be specified." },
            new TranslationEntry { TranslationId = 1, KeyId = 480, Value = "Cannot request a key for a player that's not in your tribe." },
            new TranslationEntry { TranslationId = 1, KeyId = 481, Value = "This user already has a Vault key." },
            new TranslationEntry { TranslationId = 1, KeyId = 482, Value = "Invalid Vault key." },
            new TranslationEntry { TranslationId = 1, KeyId = 483, Value = "No user exists with that Vault key." },
            new TranslationEntry { TranslationId = 1, KeyId = 484, Value = "You cannot delete your own key." },
            new TranslationEntry { TranslationId = 1, KeyId = 485, Value = "You cannot delete an admin user that you have not created." },
            new TranslationEntry { TranslationId = 1, KeyId = 486, Value = "You cannot change admin status of your own key." },
            new TranslationEntry { TranslationId = 1, KeyId = 487, Value = "You cannot change admin status of a user that you have not created." },
            new TranslationEntry { TranslationId = 1, KeyId = 488, Value = "None" },
            new TranslationEntry { TranslationId = 1, KeyId = 489, Value = "Offense" },
            new TranslationEntry { TranslationId = 1, KeyId = 491, Value = "hours" },
            new TranslationEntry { TranslationId = 1, KeyId = 493, Value = "Nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 494, Value = "Name" },
            new TranslationEntry { TranslationId = 1, KeyId = 495, Value = "Options" },
            new TranslationEntry { TranslationId = 1, KeyId = 496, Value = "No incomings to upload." },
            new TranslationEntry { TranslationId = 1, KeyId = 497, Value = "An error occurred while uploading data." },
            new TranslationEntry { TranslationId = 1, KeyId = 498, Value = "noble, nobleman, nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 499, Value = "Noble" },
            new TranslationEntry { TranslationId = 1, KeyId = 501, Value = "Your support from" },
            new TranslationEntry { TranslationId = 1, KeyId = 503, Value = "Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 504, Value = "Vault Tagging" },
            new TranslationEntry { TranslationId = 1, KeyId = 505, Value = "Distance between the source and target village" },
            new TranslationEntry { TranslationId = 1, KeyId = 506, Value = "Preview" },
            new TranslationEntry { TranslationId = 1, KeyId = 507, Value = "Vault - commands from here" },
            new TranslationEntry { TranslationId = 1, KeyId = 510, Value = "Alerts" },
            new TranslationEntry { TranslationId = 1, KeyId = 511, Value = "unit" },
            new TranslationEntry { TranslationId = 1, KeyId = 512, Value = "url" },
            new TranslationEntry { TranslationId = 1, KeyId = 513, Value = "Help" },
            new TranslationEntry { TranslationId = 1, KeyId = 514, Value = "Translations" },
            new TranslationEntry { TranslationId = 1, KeyId = 515, Value = "Language:" },
            new TranslationEntry { TranslationId = 1, KeyId = 516, Value = "Translation:" },
            new TranslationEntry { TranslationId = 1, KeyId = 517, Value = "Save Settings" },
            new TranslationEntry { TranslationId = 1, KeyId = 518, Value = "Edit Translation" },
            new TranslationEntry { TranslationId = 1, KeyId = 519, Value = "New Translation" },
            new TranslationEntry { TranslationId = 1, KeyId = 520, Value = "Save Changes" },
            new TranslationEntry { TranslationId = 1, KeyId = 521, Value = "{name} by {author}" },
            new TranslationEntry { TranslationId = 1, KeyId = 522, Value = "Key" },
            new TranslationEntry { TranslationId = 1, KeyId = 523, Value = "Value" },
            new TranslationEntry { TranslationId = 1, KeyId = 524, Value = "English Sample" },
            new TranslationEntry { TranslationId = 1, KeyId = 525, Value = "The translation for {keyName} is missing: {parameters}" },
            new TranslationEntry { TranslationId = 1, KeyId = 526, Value = "Note: This is in-game text, it must match EXACTLY!" },
            new TranslationEntry { TranslationId = 1, KeyId = 527, Value = "Saved changes!" },
            new TranslationEntry { TranslationId = 1, KeyId = 528, Value = "Delete Translation" },
            new TranslationEntry { TranslationId = 1, KeyId = 529, Value = "Are you sure you want to delete your translation, \"{name}\"?" },
            new TranslationEntry { TranslationId = 1, KeyId = 530, Value = "You cannot delete a translation that is being used as a default!" },
            new TranslationEntry { TranslationId = 1, KeyId = 531, Value = "You haven't saved your translation yet!" },
            new TranslationEntry { TranslationId = 1, KeyId = 532, Value = "Successfully deleted the translation." },
            new TranslationEntry { TranslationId = 1, KeyId = 534, Value = "You already have a translation with the name \"{name}\"!" },
            new TranslationEntry { TranslationId = 1, KeyId = 535, Value = "Since you don't own this translation, you'll be editing a copy instead." },
            new TranslationEntry { TranslationId = 1, KeyId = 536, Value = "No recent army data available." },
            new TranslationEntry { TranslationId = 1, KeyId = 537, Value = "No recent building data available." },
            new TranslationEntry { TranslationId = 1, KeyId = 538, Value = "{day}/{month}/{year}" },
            new TranslationEntry { TranslationId = 1, KeyId = 539, Value = "Enemy" },
            new TranslationEntry { TranslationId = 1, KeyId = 540, Value = "The Wall has been damaged and downgraded from level {oldLevel} to level {newLevel}" },
            new TranslationEntry { TranslationId = 1, KeyId = 541, Value = "The {buildingName} has been damaged and downgraded from level {oldLevel} to level {newLevel}" },
            new TranslationEntry { TranslationId = 1, KeyId = 543, Value = "Target Village" },
            new TranslationEntry { TranslationId = 1, KeyId = 544, Value = "Fangs have at least {numCats} catapults and at most {maxPop} population" },
            new TranslationEntry { TranslationId = 1, KeyId = 545, Value = "Fangs Traveling" },
            new TranslationEntry { TranslationId = 1, KeyId = 546, Value = "Total Fangs" },
            new TranslationEntry { TranslationId = 1, KeyId = 547, Value = "Settings" },
            new TranslationEntry { TranslationId = 1, KeyId = 548, Value = "No report folders are being ignored." },
            new TranslationEntry { TranslationId = 1, KeyId = 549, Value = "Deleted Folder" },
            new TranslationEntry { TranslationId = 1, KeyId = 550, Value = "Ignore Folder" },
            new TranslationEntry { TranslationId = 1, KeyId = 551, Value = "Report Upload Options" },
            new TranslationEntry { TranslationId = 1, KeyId = 552, Value = "Ignored Report Folders" },
            new TranslationEntry { TranslationId = 1, KeyId = 553, Value = "All report folders are being ignored by your settings!" },
            new TranslationEntry { TranslationId = 1, KeyId = 554, Value = "{month} {day}, {year} {hour}:{minute}:{second}:{millis}" },
            new TranslationEntry { TranslationId = 1, KeyId = 555, Value = "Points" },
            new TranslationEntry { TranslationId = 1, KeyId = 556, Value = "Minimum village points:" },
            new TranslationEntry { TranslationId = 1, KeyId = 557, Value = "{hour}:{minute}:{second}:{millis}\n\n{hour}:{minute}:{second}\n\n{hour}:{minute}" },
            new TranslationEntry { TranslationId = 1, KeyId = 558, Value = "{monthName} {day}, {year}\n\n{day}/{month}/{year}\n\n{day}.{month}." },
            new TranslationEntry { TranslationId = 1, KeyId = 559, Value = "{monthName} {day}, {hour}:{minute}\n\n{monthName} {day},{year} {hour}:{minute}\n\n{hour}:{minute}:{second}:{millisecond} on {day}:{month}:{year}" },
            new TranslationEntry { TranslationId = 1, KeyId = 560, Value = "Receiving nukes" },

            // Hungarian translations (TranslationId = 2)
            // TABS
            new TranslationEntry { TranslationId = 2, KeyId = 139, Value = "Védelem küldése" }, // TAB_SEND_STACKS
            new TranslationEntry { TranslationId = 2, KeyId = 301, Value = "Eszközök" }, // TAB_TOOLS
            new TranslationEntry { TranslationId = 2, KeyId = 302, Value = "Fake szkript" }, // TAB_FAKE_SCRIPT
            new TranslationEntry { TranslationId = 2, KeyId = 315, Value = "Visszacsapás kereső" }, // TAB_FIND_BACKTIMES
            new TranslationEntry { TranslationId = 2, KeyId = 327, Value = "Feltöltés" }, // TAB_UPLOAD
            new TranslationEntry { TranslationId = 2, KeyId = 145, Value = "Nemes célpontok" }, // TAB_NOBLE_TARGETS
            new TranslationEntry { TranslationId = 2, KeyId = 152, Value = "Felesleges védelem" }, // TAB_USELESS_STACKS
            new TranslationEntry { TranslationId = 2, KeyId = 157, Value = "Gyors támogatás" }, // TAB_QUICK_SUPPORT
            new TranslationEntry { TranslationId = 2, KeyId = 165, Value = "Védelem kérése" }, // TAB_REQUEST_STACK
            new TranslationEntry { TranslationId = 2, KeyId = 170, Value = "Admin" }, // TAB_ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 173, Value = "Ellenséges klánok" }, // TAB_ENEMY_TRIBES
            new TranslationEntry { TranslationId = 2, KeyId = 181, Value = "Felhasználók kezelése" }, // TAB_MANAGE_USERS
            new TranslationEntry { TranslationId = 2, KeyId = 187, Value = "Klán statisztikák" }, // TAB_TRIBE_STATS
            new TranslationEntry { TranslationId = 2, KeyId = 192, Value = "Napló" }, // TAB_LOG
            new TranslationEntry { TranslationId = 2, KeyId = 275, Value = "Statisztikák" }, // TAB_STATS
            new TranslationEntry { TranslationId = 2, KeyId = 282, Value = "Profilom" }, // TAB_ME
            new TranslationEntry { TranslationId = 2, KeyId = 294, Value = "Toplista" }, // TAB_HIGH_SCORES
            new TranslationEntry { TranslationId = 2, KeyId = 297, Value = "Támogatás" }, // TAB_SUPPORT
            new TranslationEntry { TranslationId = 2, KeyId = 298, Value = "Feltételek" }, // TAB_TERMS
            new TranslationEntry { TranslationId = 2, KeyId = 122, Value = "Foglalás visszaküldése" }, // TAB_SEND_RECAP
            new TranslationEntry { TranslationId = 2, KeyId = 123, Value = "Műveletek és riasztások" }, // TAB_ACTIONS_ALERTS
            new TranslationEntry { TranslationId = 2, KeyId = 133, Value = "Szükséges snipe-ok" }, // TAB_SNIPES_NEEDED
            new TranslationEntry { TranslationId = 2, KeyId = 510, Value = "Riasztások" }, // TAB_ALERTS
            new TranslationEntry { TranslationId = 2, KeyId = 513, Value = "Súgó" }, // TAB_HELP
            new TranslationEntry { TranslationId = 2, KeyId = 514, Value = "Fordítások" }, // TAB_TRANSLATIONS

            // ACTIONS
            new TranslationEntry { TranslationId = 2, KeyId = 134, Value = "Nincs szükség snipe-ra" }, // ACTIONS_SNIPES_NONE
            new TranslationEntry { TranslationId = 2, KeyId = 135, Value = "Bejövő nemesek, amelyeket meg kell állítani" }, // ACTIONS_SNIPES_DESCRIPTION
            new TranslationEntry { TranslationId = 2, KeyId = 136, Value = "nemes Szám" }, // ACTIONS_SNIPES_NUM_NOBLES
            new TranslationEntry { TranslationId = 2, KeyId = 140, Value = "Nincs védelem nélküli falu" }, // ACTIONS_STACKS_NONE
            new TranslationEntry { TranslationId = 2, KeyId = 141, Value = "Megehető nuke-ok" }, // ACTIONS_STACKS_EATABLE_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 142, Value = "Védelem nélküli falvak az utolsó 24 órából" }, // ACTIONS_STACKS_DESCRIPTION
            new TranslationEntry { TranslationId = 2, KeyId = 143, Value = "Lehetséges nuke-ok" }, // ACTIONS_STACKS_POSSIBLE_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 144, Value = "Jelenlegi védelem" }, // ACTIONS_STACKS_CURRENT_STRENGTH
            new TranslationEntry { TranslationId = 2, KeyId = 159, Value = "Gyors támogatás küldése védtelen falvakba" }, // ACTIONS_QUICK_SUPPORT_DESCRIPTION
            new TranslationEntry { TranslationId = 2, KeyId = 160, Value = "Minimum védő" }, // ACTIONS_QUICK_SUPPORT_SETTINGS_1
            new TranslationEntry { TranslationId = 2, KeyId = 161, Value = "Maximum utazási idő" }, // ACTIONS_QUICK_SUPPORT_SETTINGS_2
            new TranslationEntry { TranslationId = 2, KeyId = 162, Value = "Csak  mezőn belül" }, // ACTIONS_QUICK_SUPPORT_SETTINGS_3
            new TranslationEntry { TranslationId = 2, KeyId = 166, Value = "Védelem kérése a saját falvaidhoz" }, // ACTIONS_REQUEST_STACK_DESCRIPTION
            new TranslationEntry { TranslationId = 2, KeyId = 167, Value = "Minimum  védő kérése" }, // ACTIONS_REQUEST_STACK_SETTINGS_1
            new TranslationEntry { TranslationId = 2, KeyId = 168, Value = "Maximum  óra várakozás" }, // ACTIONS_REQUEST_STACK_SETTINGS_2
            new TranslationEntry { TranslationId = 2, KeyId = 169, Value = " védő per kérés" }, // ACTIONS_REQUEST_STACK_SETTINGS_3
            new TranslationEntry { TranslationId = 2, KeyId = 146, Value = "Nincs elérhető nemes célpont" }, // ACTIONS_NOBLE_TARGETS_NONE
            new TranslationEntry { TranslationId = 2, KeyId = 147, Value = "Védelem kora" }, // ACTIONS_NOBLE_TARGETS_DV_AGE
            new TranslationEntry { TranslationId = 2, KeyId = 148, Value = "Potenciális célpontok nemesítéshez" }, // ACTIONS_NOBLE_TARGETS_DESCRIPTION
            new TranslationEntry { TranslationId = 2, KeyId = 149, Value = "Állomásozó védelem" }, // ACTIONS_NOBLE_TARGETS_STATIONED_DVS
            new TranslationEntry { TranslationId = 2, KeyId = 150, Value = "Védelem látva ekkor" }, // ACTIONS_NOBLE_TARGETS_DVS_SEEN_AT
            new TranslationEntry { TranslationId = 2, KeyId = 556, Value = "Minimum pont" }, // ACTIONS_NOBLE_TARGETS_MIN_POINTS
            new TranslationEntry { TranslationId = 2, KeyId = 153, Value = "Nincs felesleges védelem" }, // ACTIONS_USELESS_STACKS_NONE
            new TranslationEntry { TranslationId = 2, KeyId = 154, Value = "Védelem, amely nem véd semmit" }, // ACTIONS_USELESS_STACKS_DESCRIPTION
            new TranslationEntry { TranslationId = 2, KeyId = 156, Value = " népesség" }, // ACTIONS_USELESS_STACKS_POP_COUNT
            new TranslationEntry { TranslationId = 2, KeyId = 124, Value = "Nincs elérhető foglalás" }, // ACTIONS_RECAPS_NONE
            new TranslationEntry { TranslationId = 2, KeyId = 125, Value = "Kor" }, // ACTIONS_RECAPS_AGE
            new TranslationEntry { TranslationId = 2, KeyId = 126, Value = "Legutóbbi foglalások a környéken" }, // ACTIONS_RECAPS_DESCRIPTION
            new TranslationEntry { TranslationId = 2, KeyId = 127, Value = "Csak közeli falvak" }, // ACTIONS_RECAPS_ONLY_NEARBY
            new TranslationEntry { TranslationId = 2, KeyId = 130, Value = "Elfoglalva ekkor" }, // ACTIONS_RECAPS_CAPTURED_AT
            new TranslationEntry { TranslationId = 2, KeyId = 131, Value = "Előző tulajdonos" }, // ACTIONS_RECAPS_OLD_OWNER
            new TranslationEntry { TranslationId = 2, KeyId = 132, Value = "Új tulajdonos" }, // ACTIONS_RECAPS_NEW_OWNER

            // ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 206, Value = "25% nuke" }, // ADMIN_TRIBE_STATS_25%_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 207, Value = "50% nuke" }, // ADMIN_TRIBE_STATS_50%_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 208, Value = "75% nuke" }, // ADMIN_TRIBE_STATS_75%_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 209, Value = "Összes teljes nuke" }, // ADMIN_TRIBE_STATS_TOTAL_FULL_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 210, Value = "Összes nemes" }, // ADMIN_TRIBE_STATS_TOTAL_NOBLES
            new TranslationEntry { TranslationId = 2, KeyId = 211, Value = "Lehetséges nemesek" }, // ADMIN_TRIBE_STATS_TOTAL_POSSIBLE_NOBLES
            new TranslationEntry { TranslationId = 2, KeyId = 212, Value = "Összes védelem" }, // ADMIN_TRIBE_STATS_TOTAL_DVS
            new TranslationEntry { TranslationId = 2, KeyId = 213, Value = "Összes bejövő" }, // ADMIN_TRIBE_STATS_TOTAL_INCS
            new TranslationEntry { TranslationId = 2, KeyId = 214, Value = "Összes támadás" }, // ADMIN_TRIBE_STATS_TOTAL_ATTACKS
            new TranslationEntry { TranslationId = 2, KeyId = 215, Value = "Feltöltés szükséges" }, // ADMIN_TRIBE_STATS_NEEDS_UPLOAD
            new TranslationEntry { TranslationId = 2, KeyId = 218, Value = "Teljes nuke-ok" }, // ADMIN_TRIBE_STATS_FULL_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 219, Value = "Úton lévő nuke-ok" }, // ADMIN_TRIBE_STATS_NUKES_TRAVELING
            new TranslationEntry { TranslationId = 2, KeyId = 221, Value = "Birtokolt védelem" }, // ADMIN_TRIBE_STATS_OWNED_DVS
            new TranslationEntry { TranslationId = 2, KeyId = 222, Value = "Otthoni védelem" }, // ADMIN_TRIBE_STATS_DVS_HOME
            new TranslationEntry { TranslationId = 2, KeyId = 223, Value = "Hátsó vonal védelem otthon" }, // ADMIN_TRIBE_STATS_BACKLINE_DVS_HOME
            new TranslationEntry { TranslationId = 2, KeyId = 224, Value = "Úton lévő védelem" }, // ADMIN_TRIBE_STATS_DVS_TRAVELING
            new TranslationEntry { TranslationId = 2, KeyId = 225, Value = "Védelem magának" }, // ADMIN_TRIBE_STATS_DVS_TO_SELF
            new TranslationEntry { TranslationId = 2, KeyId = 226, Value = "Védelem másoknak" }, // ADMIN_TRIBE_STATS_DVS_TO_OTHERS
            new TranslationEntry { TranslationId = 2, KeyId = 227, Value = "Támadó falvak" }, // ADMIN_TRIBE_STATS_OFF_VILLAS
            new TranslationEntry { TranslationId = 2, KeyId = 228, Value = "Védekező falvak" }, // ADMIN_TRIBE_STATS_DEF_VILLAS
            new TranslationEntry { TranslationId = 2, KeyId = 229, Value = "Bejövők száma" }, // ADMIN_TRIBE_STATS_NUM_INCS
            new TranslationEntry { TranslationId = 2, KeyId = 230, Value = "Támadások száma" }, // ADMIN_TRIBE_STATS_NUM_ATTACKS
            new TranslationEntry { TranslationId = 2, KeyId = 231, Value = "Védelem a klánnak" }, // ADMIN_TRIBE_STATS_DVS_TO_TRIBE
            new TranslationEntry { TranslationId = 2, KeyId = 189, Value = "Klán statisztikák és áttekintés" }, // ADMIN_TRIBE_STATS_DESCRIPTION
            new TranslationEntry { TranslationId = 2, KeyId = 190, Value = "Nuke beállítások" }, // ADMIN_TRIBE_STATS_SETTINGS_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 546, Value = "Összes fog" }, // ADMIN_TOTAL_FANGS

            // ADMIN - Log entries
            new TranslationEntry { TranslationId = 2, KeyId = 464, Value = "Jogosultságok visszavonva:" }, // ADMIN_LOG_REVOKED_PRIVELEGES_FOR
            new TranslationEntry { TranslationId = 2, KeyId = 465, Value = "Jogosultságok adva: " }, // ADMIN_LOG_GAVE_PRIVELEGES_TO
            new TranslationEntry { TranslationId = 2, KeyId = 466, Value = "Kulcs újraengedélyezve: " }, // ADMIN_LOG_RE_ENABLED_KEY_FOR
            new TranslationEntry { TranslationId = 2, KeyId = 467, Value = "Kulcs letiltva: " }, // ADMIN_LOG_DISABLED_KEY_FOR
            new TranslationEntry { TranslationId = 2, KeyId = 468, Value = "Kulcs tulajdonos változtatva:  → " }, // ADMIN_LOG_CHANGED_KEY_OWNER
            new TranslationEntry { TranslationId = 2, KeyId = 469, Value = "Csak olvasható mód beállítva: " }, // ADMIN_LOG_SET_READ_ONLY
            new TranslationEntry { TranslationId = 2, KeyId = 470, Value = "Csak olvasható mód eltávolítva: " }, // ADMIN_LOG_REMOVED_READ_ONLY
            new TranslationEntry { TranslationId = 2, KeyId = 471, Value = "Szerver változtatva:  → " }, // ADMIN_LOG_CHANGED_SERVER
            new TranslationEntry { TranslationId = 2, KeyId = 472, Value = "Admin törlése: " }, // ADMIN_LOG_CLEARED_ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 473, Value = "Admin hozzárendelése: " }, // ADMIN_LOG_ASSIGNED_ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 474, Value = "Admin változtatása: " }, // ADMIN_LOG_CHANGED_ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 475, Value = "Ismeretlen változtatás" }, // ADMIN_LOG_UNKNOWN_CHANGE
            new TranslationEntry { TranslationId = 2, KeyId = 476, Value = "Kulcs törölve: " }, // ADMIN_LOG_DELETED_KEY
            new TranslationEntry { TranslationId = 2, KeyId = 463, Value = "Kulcs hozzáadva: " }, // ADMIN_LOG_ADDED_KEY_FOR

            // ADMIN - User Management
            new TranslationEntry { TranslationId = 2, KeyId = 478, Value = "Játékos nem található:" }, // ADMIN_PLAYER_NOT_FOUND_NAME
            new TranslationEntry { TranslationId = 2, KeyId = 477, Value = "Játékos nem található ID:" }, // ADMIN_PLAYER_NOT_FOUND_ID
            new TranslationEntry { TranslationId = 2, KeyId = 479, Value = "Játékosnév nincs megadva" }, // ADMIN_PLAYER_NAME_NOT_SET
            new TranslationEntry { TranslationId = 2, KeyId = 480, Value = "A játékos nincs klánban" }, // ADMIN_PLAYER_NOT_IN_TRIBE
            new TranslationEntry { TranslationId = 2, KeyId = 481, Value = "A játékosnak már van kulcsa" }, // ADMIN_PLAYER_HAS_KEY
            new TranslationEntry { TranslationId = 2, KeyId = 482, Value = "Érvénytelen kulcs" }, // ADMIN_INVALID_KEY
            new TranslationEntry { TranslationId = 2, KeyId = 483, Value = "Kulcs nem található" }, // ADMIN_KEY_NOT_FOUND
            new TranslationEntry { TranslationId = 2, KeyId = 484, Value = "Nem törölheted a saját kulcsod" }, // ADMIN_DELETE_OWN_KEY
            new TranslationEntry { TranslationId = 2, KeyId = 485, Value = "Nem törölhetsz másik admint" }, // ADMIN_DELETE_OTHER_ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 486, Value = "Nem változtathatod meg a saját kulcsod" }, // ADMIN_CHANGE_OWN_KEY
            new TranslationEntry { TranslationId = 2, KeyId = 487, Value = "Nem változtathatsz másik admint" }, // ADMIN_CHANGE_OTHER_ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 193, Value = "Felhasználói napló" }, // ADMIN_USER_LOG
            new TranslationEntry { TranslationId = 2, KeyId = 197, Value = "Játékosnév megadása" }, // ADMIN_MANAGE_USERS_ENTER_NAME
            new TranslationEntry { TranslationId = 2, KeyId = 199, Value = "Admin jogok adása" }, // ADMIN_MANAGE_USERS_GIVE_ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 200, Value = "Admin jogok visszavonása" }, // ADMIN_MANAGE_USERS_REVOKE_ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 202, Value = "Biztosan törlöd ezt a kulcsot?" }, // ADMIN_MANAGE_USERS_CONFIRM_DELETE
            new TranslationEntry { TranslationId = 2, KeyId = 203, Value = "Biztosan visszavonod az admin jogokat?" }, // ADMIN_MANAGE_USERS_CONFIRM_REMOVE_ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 204, Value = "Biztosan adsz admin jogokat?" }, // ADMIN_MANAGE_USERS_CONFIRM_GIVE_ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 205, Value = "Vault szkript ehhez:" }, // ADMIN_MANAGE_USERS_VAULT_SCRIPT_FOR
            new TranslationEntry { TranslationId = 2, KeyId = 183, Value = "Új kulcs" }, // ADMIN_NEW_KEY
            new TranslationEntry { TranslationId = 2, KeyId = 184, Value = "Új Vault szkript" }, // ADMIN_NEW_VAULT_SCRIPT

            // ADMIN - Enemy Tribes
            new TranslationEntry { TranslationId = 2, KeyId = 172, Value = "Ellenség eltávolítása" }, // ADMIN_REMOVE_ENEMY
            new TranslationEntry { TranslationId = 2, KeyId = 174, Value = "Hiba az ellenséges klánok betöltésekor" }, // ERROR_LOADING_ENEMY_TRIBES
            new TranslationEntry { TranslationId = 2, KeyId = 175, Value = "Klán neve" }, // ADMIN_NAME_OF_TRIBE
            new TranslationEntry { TranslationId = 2, KeyId = 176, Value = "Klán nem található" }, // ADMIN_TRIBE_NOT_FOUND
            new TranslationEntry { TranslationId = 2, KeyId = 177, Value = "A klán már létezik" }, // ADMIN_TRIBE_ALREADY_EXISTS
            new TranslationEntry { TranslationId = 2, KeyId = 178, Value = "Enemy Tribes" },
            new TranslationEntry { TranslationId = 2, KeyId = 179, Value = "Tell the Vault which tribes to consider as \"enemies\" when determining which villages are back-line." },
            new TranslationEntry { TranslationId = 2, KeyId = 180, Value = "Add Enemy Tribe" },
            new TranslationEntry { TranslationId = 2, KeyId = 181, Value = "Manage Users" },

            // TIME formats
            new TranslationEntry { TranslationId = 2, KeyId = 137, Value = "Érkezik" }, // LANDS_AT
            new TranslationEntry { TranslationId = 2, KeyId = 455, Value = "ó" }, // TIME_HOUR_SHORT
            new TranslationEntry { TranslationId = 2, KeyId = 456, Value = "p" }, // TIME_MINUTE_SHORT
            new TranslationEntry { TranslationId = 2, KeyId = 457, Value = "mp" }, // TIME_SECOND_SHORT
            new TranslationEntry { TranslationId = 2, KeyId = 454, Value = "n" }, // TIME_DAY_SHORT
            new TranslationEntry { TranslationId = 2, KeyId = 458, Value = "n" }, // TIME_DAY_PLURAL_SHORT
            new TranslationEntry { TranslationId = 2, KeyId = 459, Value = "ó" }, // TIME_HOUR_PLURAL_SHORT
            new TranslationEntry { TranslationId = 2, KeyId = 460, Value = "p" }, // TIME_MINUTE_PLURAL_SHORT
            new TranslationEntry { TranslationId = 2, KeyId = 461, Value = "mp" }, // TIME_SECOND_PLURAL_SHORT
            new TranslationEntry { TranslationId = 2, KeyId = 449, Value = "ma -kor" }, // TIME_TODAY_AT
            new TranslationEntry { TranslationId = 2, KeyId = 450, Value = "holnap -kor" }, // TIME_TOMORROW_AT
            new TranslationEntry { TranslationId = 2, KeyId = 451, Value = "-án" }, // TIME_ON
            new TranslationEntry { TranslationId = 2, KeyId = 452, Value = "-án -kor" }, // TIME_ON_AT
            new TranslationEntry { TranslationId = 2, KeyId = 453, Value = "yyyy.MM.dd" }, // TIME_DATE_FORMAT
            new TranslationEntry { TranslationId = 2, KeyId = 538, Value = "TIME_NUMERIC_DATE" }, // TIME_NUMERIC_DATE
            new TranslationEntry { TranslationId = 2, KeyId = 554, Value = "yyyy.MM.dd HH:mm:ss" }, // TIME_FULL_FORMAT
            new TranslationEntry { TranslationId = 2, KeyId = 557, Value = "HH:mm:ss;H:mm:ss" }, // TIME_EXTRA_TIME_FORMATS
            new TranslationEntry { TranslationId = 2, KeyId = 558, Value = "yyyy.MM.dd;yyyy/MM/dd" }, // TIME_EXTRA_DATE_FORMATS
            new TranslationEntry { TranslationId = 2, KeyId = 559, Value = "yyyy.MM.dd HH:mm:ss;yyyy/MM/dd HH:mm:ss" }, // TIME_EXTRA_FULL_FORMATS

            // BUILDINGS
            new TranslationEntry { TranslationId = 2, KeyId = 418, Value = "Barakk" }, // BUILDING_BARRACKS
            new TranslationEntry { TranslationId = 2, KeyId = 419, Value = "Istálló" }, // BUILDING_STABLE
            new TranslationEntry { TranslationId = 2, KeyId = 420, Value = "Műhely" }, // BUILDING_WORKSHOP
            new TranslationEntry { TranslationId = 2, KeyId = 421, Value = "Akadémia" }, // BUILDING_ACADEMY
            new TranslationEntry { TranslationId = 2, KeyId = 422, Value = "Kovács" }, // BUILDING_SMITHY
            new TranslationEntry { TranslationId = 2, KeyId = 423, Value = "Gyülekezőhely" }, // BUILDING_RALLY_POINT
            new TranslationEntry { TranslationId = 2, KeyId = 424, Value = "Szobor" }, // BUILDING_STATUE
            new TranslationEntry { TranslationId = 2, KeyId = 417, Value = "Főhadiszállás" }, // BUILDING_HQ
            new TranslationEntry { TranslationId = 2, KeyId = 425, Value = "Piac" }, // BUILDING_MARKET
            new TranslationEntry { TranslationId = 2, KeyId = 426, Value = "Fatelep" }, // BUILDING_TIMBER_CAMP
            new TranslationEntry { TranslationId = 2, KeyId = 427, Value = "Agyagbánya" }, // BUILDING_CLAY_PIT
            new TranslationEntry { TranslationId = 2, KeyId = 428, Value = "Vasbánya" }, // BUILDING_IRON_MINE
            new TranslationEntry { TranslationId = 2, KeyId = 429, Value = "Tanya" }, // BUILDING_FARM
            new TranslationEntry { TranslationId = 2, KeyId = 430, Value = "Raktár" }, // BUILDING_WAREHOUSE
            new TranslationEntry { TranslationId = 2, KeyId = 431, Value = "Rejtekhely" }, // BUILDING_HIDING_PLACE
            new TranslationEntry { TranslationId = 2, KeyId = 432, Value = "Fal" }, // BUILDING_WALL
            new TranslationEntry { TranslationId = 2, KeyId = 433, Value = "Őrtorony" }, // BUILDING_WATCHTOWER
            new TranslationEntry { TranslationId = 2, KeyId = 434, Value = "Templom" }, // BUILDING_CHURCH

            // UNITS
            new TranslationEntry { TranslationId = 2, KeyId = 399, Value = "Lándzsás" }, // UNIT_SPEAR
            new TranslationEntry { TranslationId = 2, KeyId = 400, Value = "lándzsás;lándzsások;landzsa;lándzsa" }, // UNIT_SPEAR_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 401, Value = "Kardforgató" }, // UNIT_SWORD
            new TranslationEntry { TranslationId = 2, KeyId = 402, Value = "kardforgató;kardforgatók;kard;kardos" }, // UNIT_SWORD_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 403, Value = "Bárdos" }, // UNIT_AXE
            new TranslationEntry { TranslationId = 2, KeyId = 404, Value = "bárdos;bárdosok;bárd;fejsze" }, // UNIT_AXE_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 405, Value = "Íjász" }, // UNIT_ARCHER
            new TranslationEntry { TranslationId = 2, KeyId = 406, Value = "íjász;íjászok;íj" }, // UNIT_ARCHER_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 407, Value = "Kém" }, // UNIT_SPY
            new TranslationEntry { TranslationId = 2, KeyId = 408, Value = "kém;kémek;felderítő" }, // UNIT_SPY_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 409, Value = "Könnyűlovas" }, // UNIT_LIGHT_CAV
            new TranslationEntry { TranslationId = 2, KeyId = 410, Value = "könnyűlovas;könnyűlovasok;könnyű;kl" }, // UNIT_LIGHT_CAV_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 411, Value = "Lovas íjász" }, // UNIT_M_ARCHER
            new TranslationEntry { TranslationId = 2, KeyId = 412, Value = "lovas íjász;lovas íjászok;lí;lovasíjász" }, // UNIT_M_ARCHER_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 413, Value = "Nehézlovas" }, // UNIT_HEAVY_CAV
            new TranslationEntry { TranslationId = 2, KeyId = 414, Value = "nehézlovas;nehézlovasok;nehéz;nl" }, // UNIT_HEAVY_CAV_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 395, Value = "Faltörő kos" }, // UNIT_RAM
            new TranslationEntry { TranslationId = 2, KeyId = 396, Value = "faltörő kos;faltörő;kos" }, // UNIT_RAM_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 397, Value = "Katapult" }, // UNIT_CATAPULT
            new TranslationEntry { TranslationId = 2, KeyId = 398, Value = "katapult;katapultok;kata;kat" }, // UNIT_CATAPULT_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 415, Value = "Lovag" }, // UNIT_PALADIN
            new TranslationEntry { TranslationId = 2, KeyId = 416, Value = "lovag" }, // UNIT_PALADIN_ALIASES
            new TranslationEntry { TranslationId = 2, KeyId = 499, Value = "Nemes" }, // UNIT_NOBLE
            new TranslationEntry { TranslationId = 2, KeyId = 498, Value = "nemes;nemesek;főnemes" }, // UNIT_NOBLE_ALIASES

            // BACKTIME
            new TranslationEntry { TranslationId = 2, KeyId = 10, Value = "BB kód másolása" }, // BACKTIME_BB_CODE_HOVER
            new TranslationEntry { TranslationId = 2, KeyId = 11, Value = "Adatok feltöltése szükséges" }, // BACKTIME_UPLOAD_DATA_REQUIRED
            new TranslationEntry { TranslationId = 2, KeyId = 314, Value = "Visszacsapás eredmények" }, // BACKTIME_RESULTS
            new TranslationEntry { TranslationId = 2, KeyId = 321, Value = "Minimum támadás méret" }, // BACKTIME_MIN_ATTACK_SIZE_1
            new TranslationEntry { TranslationId = 2, KeyId = 322, Value = "népesség" }, // BACKTIME_MIN_ATTACK_SIZE_2
            new TranslationEntry { TranslationId = 2, KeyId = 323, Value = "Maximum utazási idő" }, // BACKTIME_MAX_TRAVEL_TIME
            new TranslationEntry { TranslationId = 2, KeyId = 324, Value = "Maximum időzítések száma" }, // BACKTIME_MAX_NUM_TIMINGS
            new TranslationEntry { TranslationId = 2, KeyId = 325, Value = "Kezelt nuke-ok elrejtése" }, // BACKTIME_HIDE_HANDLED_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 326, Value = "Védett nuke-ok elrejtése" }, // BACKTIME_HIDE_STACKED_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 316, Value = "Számítás folyamatban..." }, // BACKTIME_WORKING
            new TranslationEntry { TranslationId = 2, KeyId = 318, Value = "Találj visszatérő egységeket a nuke-okhoz" }, // BACKTIME_DESCRIPTION_1
            new TranslationEntry { TranslationId = 2, KeyId = 319, Value = "A visszacsapás időzítése alapján" }, // BACKTIME_DESCRIPTION_2
            new TranslationEntry { TranslationId = 2, KeyId = 320, Value = "Minimum visszatérő népesség" }, // BACKTIME_MIN_RETURNING_POPULATION
            new TranslationEntry { TranslationId = 2, KeyId = 491, Value = "óra" }, // BACKTIME_HOURS

            // REPORTS
            new TranslationEntry { TranslationId = 2, KeyId = 371, Value = "Feltöltött jelentések ellenőrzése" }, // REPORTS_CHECK_UPLOADED
            new TranslationEntry { TranslationId = 2, KeyId = 372, Value = "Farm asszisztens nem található" }, // REPORTS_LA_NOT_FOUND
            new TranslationEntry { TranslationId = 2, KeyId = 373, Value = "Farm asszisztens" }, // REPORTS_LOOT_ASSISTANT
            new TranslationEntry { TranslationId = 2, KeyId = 374, Value = "Farm asszisztens szűrése" }, // REPORTS_FILTERING_LA
            new TranslationEntry { TranslationId = 2, KeyId = 375, Value = "Farm asszisztens hiba" }, // REPORTS_LA_ERROR
            new TranslationEntry { TranslationId = 2, KeyId = 376, Value = "Régi jelentések kihagyva" }, // REPORTS_SKIPPED_OLD
            new TranslationEntry { TranslationId = 2, KeyId = 377, Value = "Hiba a régi jelentések ellenőrzésekor" }, // REPORTS_ERROR_CHECK_OLD
            new TranslationEntry { TranslationId = 2, KeyId = 378, Value = "Jelentések feltöltése kész" }, // REPORTS_FINISHED
            new TranslationEntry { TranslationId = 2, KeyId = 379, Value = "Nincs új jelentés" }, // REPORTS_NONE_NEW
            new TranslationEntry { TranslationId = 2, KeyId = 380, Value = "Jelentések feldolgozása" }, // REPORTS_PROGRESS
            new TranslationEntry { TranslationId = 2, KeyId = 370, Value = "Oldalak:" }, // REPORTS_PAGES_PROGRESS
            new TranslationEntry { TranslationId = 2, KeyId = 368, Value = "Oldalak gyűjtése" }, // REPORTS_COLLECTING_PAGES
            new TranslationEntry { TranslationId = 2, KeyId = 369, Value = "Linkek gyűjtése" }, // REPORTS_COLLECTING_LINKS
            new TranslationEntry { TranslationId = 2, KeyId = 435, Value = "Hűség: " }, // REPORT_LOYALTY_FROM_TO
            new TranslationEntry { TranslationId = 2, KeyId = 541, Value = "Épület sérülés" }, // REPORT_BUILDING_DAMAGE
            new TranslationEntry { TranslationId = 2, KeyId = 540, Value = "Fal sérülés" }, // REPORT_WALL_DAMAGE
            new TranslationEntry { TranslationId = 2, KeyId = 548, Value = "Nincs figyelmen kívül hagyott mappa" }, // REPORT_FOLDER_NONE_IGNORED
            new TranslationEntry { TranslationId = 2, KeyId = 549, Value = "Mappa törölve" }, // REPORT_FOLDER_DELETED
            new TranslationEntry { TranslationId = 2, KeyId = 550, Value = "Mappa figyelmen kívül hagyása" }, // REPORT_FOLDER_IGNORE
            new TranslationEntry { TranslationId = 2, KeyId = 551, Value = "Jelentés beállítások" }, // REPORT_OPTIONS
            new TranslationEntry { TranslationId = 2, KeyId = 552, Value = "Figyelmen kívül hagyott mappák" }, // REPORT_FOLDERS_IGNORED
            new TranslationEntry { TranslationId = 2, KeyId = 553, Value = "Minden figyelmen kívül hagyott feltöltése" }, // REPORTS_UPLOAD_ALL_IGNORED

            // TROOPS
            new TranslationEntry { TranslationId = 2, KeyId = 381, Value = "Oldalak gyűjtése" }, // TROOPS_COLLECTING_PAGES
            new TranslationEntry { TranslationId = 2, KeyId = 382, Value = "Akadémia keresése" }, // TROOPS_FIND_ACADEMY
            new TranslationEntry { TranslationId = 2, KeyId = 383, Value = "Nincs akadémia" }, // TROOPS_NO_ACADEMY
            new TranslationEntry { TranslationId = 2, KeyId = 384, Value = "Lehetséges nemesek keresése" }, // TROOPS_FIND_POSSIBLE_NOBLES
            new TranslationEntry { TranslationId = 2, KeyId = 385, Value = "Támogatás keresése" }, // TROOPS_FIND_SUPPORT
            new TranslationEntry { TranslationId = 2, KeyId = 386, Value = "Támogatás gyűjtése" }, // TROOPS_COLLECTING_SUPPORT
            new TranslationEntry { TranslationId = 2, KeyId = 387, Value = "Hiba az akadémia keresésekor" }, // TROOPS_ERROR_FINDING_ACADEMY
            new TranslationEntry { TranslationId = 2, KeyId = 388, Value = "Nemes limit" }, // TROOPS_NOBLES_LIMIT
            new TranslationEntry { TranslationId = 2, KeyId = 390, Value = "Hiba a nemesek lekérésekor" }, // TROOPS_ERROR_GETTING_NOBLES
            new TranslationEntry { TranslationId = 2, KeyId = 391, Value = "Csapatok feltöltése" }, // TROOPS_UPLOADING
            new TranslationEntry { TranslationId = 2, KeyId = 393, Value = "Csapatok feltöltése kész" }, // TROOPS_FINISHED
            new TranslationEntry { TranslationId = 2, KeyId = 394, Value = "Támogatás feltöltése" }, // TROOPS_UPLOADING_SUPPORT
            new TranslationEntry { TranslationId = 2, KeyId = 389, Value = "falu  nemessel" }, // TROOPS_NOBLES_NUM_VILLAGES

            // COMMANDS
            new TranslationEntry { TranslationId = 2, KeyId = 356, Value = "Parancsok oldalainak gyűjtése" }, // COMMANDS_COLLECTING_PAGES
            new TranslationEntry { TranslationId = 2, KeyId = 360, Value = "Parancsok feltöltése kész" }, // COMMANDS_FINISHED
            new TranslationEntry { TranslationId = 2, KeyId = 357, Value = "Nincs új parancs" }, // COMMANDS_NONE_NEW
            new TranslationEntry { TranslationId = 2, KeyId = 358, Value = "Feltöltött parancsok ellenőrzése" }, // COMMANDS_CHECK_UPLOADED
            new TranslationEntry { TranslationId = 2, KeyId = 359, Value = "Parancsok feltöltése" }, // COMMANDS_UPLOADING
            new TranslationEntry { TranslationId = 2, KeyId = 361, Value = "Feltöltött parancsok ellenőrzése sikertelen" }, // COMMANDS_CHECK_UPLOADED_FAILED
            new TranslationEntry { TranslationId = 2, KeyId = 362, Value = "Régi parancsok kihagyva" }, // COMMANDS_SKIPPED_OLD
            new TranslationEntry { TranslationId = 2, KeyId = 363, Value = "Parancsok feldolgozása" }, // COMMANDS_PROGRESS
            new TranslationEntry { TranslationId = 2, KeyId = 507, Value = "Innen induló parancsok" }, // COMMANDS_FROM_HERE

            // INCOMINGS
            new TranslationEntry { TranslationId = 2, KeyId = 345, Value = "Bejövők" }, // INCOMINGS
            new TranslationEntry { TranslationId = 2, KeyId = 364, Value = "Bejövő oldalak gyűjtése" }, // INCOMINGS_COLLECTING_PAGES
            new TranslationEntry { TranslationId = 2, KeyId = 365, Value = "Bejövők feldolgozása" }, // INCOMINGS_PROGRESS
            new TranslationEntry { TranslationId = 2, KeyId = 366, Value = "Bejövők feltöltése" }, // INCOMINGS_UPLOADING
            new TranslationEntry { TranslationId = 2, KeyId = 367, Value = "Bejövők feltöltése kész" }, // INCOMINGS_FINISHED
            new TranslationEntry { TranslationId = 2, KeyId = 496, Value = "Nincs bejövő támadás" }, // INCOMINGS_NONE
            new TranslationEntry { TranslationId = 2, KeyId = 497, Value = "Hiba a bejövők feltöltésekor" }, // INCOMINGS_UPLOAD_ERROR
            new TranslationEntry { TranslationId = 2, KeyId = 29, Value = "Címkézetlen bejövők" }, // INCS_NOT_TAGGED

            // FAKE SCRIPTS
            new TranslationEntry { TranslationId = 2, KeyId = 303, Value = "Dinamikus fake szkriptek" }, // DYNAMIC_FAKE_SCRIPTS
            new TranslationEntry { TranslationId = 2, KeyId = 310, Value = "Távolság beállítások" }, // FAKES_DIST_LABEL
            new TranslationEntry { TranslationId = 2, KeyId = 311, Value = "mezőnyire innen" }, // FAKES_DIST_FIELDS_FROM
            new TranslationEntry { TranslationId = 2, KeyId = 312, Value = "Koordináták lekérése" }, // GET_COORDS
            new TranslationEntry { TranslationId = 2, KeyId = 307, Value = "Minimum koordináta" }, // FAKES_MIN_COORD
            new TranslationEntry { TranslationId = 2, KeyId = 308, Value = "Maximum koordináta" }, // FAKES_MAX_COORD
            new TranslationEntry { TranslationId = 2, KeyId = 72, Value = "Fake-ek" }, // FAKES
            new TranslationEntry { TranslationId = 2, KeyId = 73, Value = "Fake" }, // FAKE
            new TranslationEntry { TranslationId = 2, KeyId = 63, Value = "Fake észlelés megerősítése" }, // FAKE_DETECTION_CONFIRM

            // MAP OVERLAY
            new TranslationEntry { TranslationId = 2, KeyId = 75, Value = "Vault használata" }, // MAP_USING_VAULT
            new TranslationEntry { TranslationId = 2, KeyId = 76, Value = "Bármilyen kiemelés" }, // MAP_HIGHLIGHT_ANY
            new TranslationEntry { TranslationId = 2, KeyId = 77, Value = "Nincs kiemelés" }, // MAP_HIGHLIGHT_NO
            new TranslationEntry { TranslationId = 2, KeyId = 539, Value = "Ellenség kiemelése" }, // MAP_HIGHLIGHT_ENEMY
            new TranslationEntry { TranslationId = 2, KeyId = 78, Value = "Térkép adatok feltöltése szükséges" }, // MAP_UPLOAD_DATA_REQUIRED
            new TranslationEntry { TranslationId = 2, KeyId = 79, Value = "Fake-ek:" }, // MAP_HOVER_CMD_FAKES
            new TranslationEntry { TranslationId = 2, KeyId = 80, Value = "Nuke-ok:" }, // MAP_HOVER_CMD_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 81, Value = "Nemesek:" }, // MAP_HOVER_CMD_NOBLES
            new TranslationEntry { TranslationId = 2, KeyId = 82, Value = "Védelem:" }, // MAP_HOVER_CMD_DVS
            new TranslationEntry { TranslationId = 2, KeyId = 83, Value = "Játékosok:" }, // MAP_HOVER_CMD_NUM_PLAYERS
            new TranslationEntry { TranslationId = 2, KeyId = 84, Value = "Otthoni sereg" }, // MAP_HOVER_ARMY_AT_HOME
            new TranslationEntry { TranslationId = 2, KeyId = 85, Value = "Állomásozó sereg" }, // MAP_HOVER_ARMY_STATIONED
            new TranslationEntry { TranslationId = 2, KeyId = 86, Value = "Úton lévő sereg" }, // MAP_HOVER_ARMY_TRAVELING
            new TranslationEntry { TranslationId = 2, KeyId = 87, Value = "Birtokolt sereg" }, // MAP_HOVER_ARMY_OWNED
            new TranslationEntry { TranslationId = 2, KeyId = 88, Value = "Lehetséges toborzás" }, // MAP_HOVER_ARMY_POSSIBLE_RECRUIT
            new TranslationEntry { TranslationId = 2, KeyId = 89, Value = "Nuke becslés" }, // MAP_HOVER_NUKE_ESTIMATE
            new TranslationEntry { TranslationId = 2, KeyId = 90, Value = "Látva ekkor" }, // MAP_HOVER_SEEN_AT
            new TranslationEntry { TranslationId = 2, KeyId = 91, Value = "Legutóbbi szintek" }, // MAP_HOVER_LATEST_LEVELS
            new TranslationEntry { TranslationId = 2, KeyId = 92, Value = "Lehetséges szintek" }, // MAP_HOVER_POSSIBLE_LEVELS
            new TranslationEntry { TranslationId = 2, KeyId = 93, Value = "Hűség" }, // MAP_HOVER_LOYALTY
            new TranslationEntry { TranslationId = 2, KeyId = 94, Value = "Legutóbbi hűség" }, // MAP_HOVER_LATEST_LOYALTY
            new TranslationEntry { TranslationId = 2, KeyId = 95, Value = "Lehetséges hűség" }, // MAP_HOVER_POSSIBLE_LOYALTY
            new TranslationEntry { TranslationId = 2, KeyId = 536, Value = "Nincs sereg" }, // MAP_HOVER_NO_ARMY
            new TranslationEntry { TranslationId = 2, KeyId = 537, Value = "Nincs épület adat" }, // MAP_HOVER_NO_BUILDINGS

            // MAP SETTINGS
            new TranslationEntry { TranslationId = 2, KeyId = 96, Value = "Lebegő információ" }, // MAP_SETTINGS_HOVER
            new TranslationEntry { TranslationId = 2, KeyId = 97, Value = "Parancsok mutatása" }, // MAP_SETTINGS_HOVER_COMMANDS
            new TranslationEntry { TranslationId = 2, KeyId = 98, Value = "Toborzás mutatása" }, // MAP_SETTINGS_HOVER_RECRUITS
            new TranslationEntry { TranslationId = 2, KeyId = 99, Value = "Épületek mutatása" }, // MAP_SETTINGS_HOVER_BUILDINGS
            new TranslationEntry { TranslationId = 2, KeyId = 100, Value = "Hűség mutatása" }, // MAP_SETTINGS_HOVER_LOYALTY
            new TranslationEntry { TranslationId = 2, KeyId = 503, Value = "Nuke-ok mutatása" }, // MAP_SETTINGS_HOVER_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 101, Value = "Átfedés beállítások" }, // MAP_SETTINGS_OVERLAY
            new TranslationEntry { TranslationId = 2, KeyId = 102, Value = "Átfedés mutatása" }, // MAP_SETTINGS_OVERLAY_SHOW
            new TranslationEntry { TranslationId = 2, KeyId = 103, Value = "Intel figyelmen kívül hagyása" }, // MAP_SETTINGS_OVERLAY_IGNORE_INTEL_1
            new TranslationEntry { TranslationId = 2, KeyId = 104, Value = "napnál régebbi" }, // MAP_SETTINGS_OVERLAY_IGNORE_INTEL_2
            new TranslationEntry { TranslationId = 2, KeyId = 105, Value = "Kiemelések" }, // MAP_SETTINGS_OVERLAY_HIGHLIGHTS
            new TranslationEntry { TranslationId = 2, KeyId = 106, Value = "Nincs kiemelés" }, // MAP_SETTINGS_OVERLAY_HIGHLIGHTS_NONE
            new TranslationEntry { TranslationId = 2, KeyId = 107, Value = "Van csoportja" }, // MAP_SETTINGS_OVERLAY_HIGHLIGHTS_HAS_GROUP
            new TranslationEntry { TranslationId = 2, KeyId = 108, Value = "Van intel adat" }, // MAP_SETTINGS_OVERLAY_HIGHLIGHTS_HAS_INTEL
            new TranslationEntry { TranslationId = 2, KeyId = 109, Value = "Nuke-ok mutatása" }, // MAP_SETTINGS_OVERLAY_SHOW_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 110, Value = "Nemesek mutatása" }, // MAP_SETTINGS_OVERLAY_SHOW_NOBLES
            new TranslationEntry { TranslationId = 2, KeyId = 111, Value = "Védelem mutatása" }, // MAP_SETTINGS_OVERLAY_SHOW_STACKS
            new TranslationEntry { TranslationId = 2, KeyId = 112, Value = "Fal mutatása" }, // MAP_SETTINGS_OVERLAY_SHOW_WALL
            new TranslationEntry { TranslationId = 2, KeyId = 560, Value = "Célpont nuke-ok mutatása" }, // MAP_SETTINGS_OVERLAY_SHOW_TARGET_NUM_NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 114, Value = "Visszatérő egységek" }, // MAP_SETTINGS_OVERLAY_RETURNING_1
            new TranslationEntry { TranslationId = 2, KeyId = 115, Value = "+ népesség" }, // MAP_SETTINGS_OVERLAY_RETURNING_2
            new TranslationEntry { TranslationId = 2, KeyId = 116, Value = "Őrtorony hatás" }, // MAP_SETTINGS_OVERLAY_WATCHTOWER
            new TranslationEntry { TranslationId = 2, KeyId = 117, Value = "Védelem ikon" }, // MAP_SETTINGS_OVERLAY_DV
            new TranslationEntry { TranslationId = 2, KeyId = 118, Value = "Védelem ikon" }, // MAP_SETTINGS_OVERLAY_STACK_1
            new TranslationEntry { TranslationId = 2, KeyId = 119, Value = "+ védő" }, // MAP_SETTINGS_OVERLAY_STACK_2
            new TranslationEntry { TranslationId = 2, KeyId = 120, Value = "Klán szűrő" }, // MAP_SETTINGS_OVERLAY_TRIBE_1
            new TranslationEntry { TranslationId = 2, KeyId = 121, Value = "Csak saját klán" }, // MAP_SETTINGS_OVERLAY_TRIBE_2

            // TAGGING
            new TranslationEntry { TranslationId = 2, KeyId = 504, Value = "Bejövők címkézése" }, // TAGGING_TITLE
            new TranslationEntry { TranslationId = 2, KeyId = 30, Value = "Címkézéshez adatok feltöltése szükséges" }, // TAG_UPLOAD_DATA_REQUIRED
            new TranslationEntry { TranslationId = 2, KeyId = 33, Value = "Címke kódok" }, // TAG_CODE_HEADER
            new TranslationEntry { TranslationId = 2, KeyId = 34, Value = "Címke részletek" }, // TAG_CODE_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 35, Value = "Egység neve" }, // TAG_CODE_TROOP_NAME_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 36, Value = "Címke típusa" }, // TAG_CODE_TAG_TYPE_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 37, Value = "Népesség százalék" }, // TAG_CODE_POP_PERCENT_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 38, Value = "Népesség szám" }, // TAG_CODE_POP_COUNT_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 39, Value = "Visszatérő népesség százalék" }, // TAG_CODE_POP_RETURN_PERCENT_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 40, Value = "Visszatérő népesség szám" }, // TAG_CODE_POP_RETURN_COUNT_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 41, Value = "Katapultok száma" }, // TAG_CODE_NUM_CATS_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 42, Value = "Parancsok száma" }, // TAG_CODE_NUM_COMS_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 43, Value = "Támadó játékos" }, // TAG_CODE_SRC_PLAYER_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 44, Value = "Támadó falu" }, // TAG_CODE_SRC_VILLAGE_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 45, Value = "Célpont játékos" }, // TAG_CODE_TGT_PLAYER_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 46, Value = "Célpont falu" }, // TAG_CODE_TGT_VILLAGE_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 47, Value = "Támadó koordináták" }, // TAG_CODE_SRC_COORDS_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 48, Value = "Célpont koordináták" }, // TAG_CODE_TGT_COORDS_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 49, Value = "Falu típusa" }, // TAG_CODE_VILLAGE_TYPE_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 50, Value = "Egyéni címke" }, // TAG_CODE_CUSTOM_LABEL_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 505, Value = "Távolság" }, // TAG_CODE_DISTANCE_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 51, Value = "Címke formátum" }, // TAG_CFG_FORMAT
            new TranslationEntry { TranslationId = 2, KeyId = 53, Value = "Csak címkézetlen" }, // TAG_CFG_ONLY_UNLABELED
            new TranslationEntry { TranslationId = 2, KeyId = 54, Value = "Automatikus fake címkézés" }, // TAG_CFG_AUTOTAG_FAKE_1
            new TranslationEntry { TranslationId = 2, KeyId = 55, Value = "népesség alatt" }, // TAG_CFG_AUTOTAG_FAKE_2
            new TranslationEntry { TranslationId = 2, KeyId = 56, Value = "Adathiányos figyelmen kívül hagyása" }, // TAG_CFG_IGNORE_NO_DATA
            new TranslationEntry { TranslationId = 2, KeyId = 57, Value = "Összes címkézése" }, // TAG_ALL
            new TranslationEntry { TranslationId = 2, KeyId = 58, Value = "Kijelöltek címkézése" }, // TAG_SELECTED
            new TranslationEntry { TranslationId = 2, KeyId = 59, Value = "Címkék visszaállítása" }, // TAG_REVERT
            new TranslationEntry { TranslationId = 2, KeyId = 61, Value = "A címkézés eltarthat egy ideig" }, // TAG_DURATION_NOTICE
            new TranslationEntry { TranslationId = 2, KeyId = 66, Value = "Címkézés megszakítva" }, // TAGGING_CANCELED
            new TranslationEntry { TranslationId = 2, KeyId = 67, Value = "Címkézés folyamatban" }, // TAGGING_PROGRESS
            new TranslationEntry { TranslationId = 2, KeyId = 68, Value = "Futás" }, // TAG_STATE_RUNNING
            new TranslationEntry { TranslationId = 2, KeyId = 69, Value = "Befejezve" }, // TAG_STATE_FINISHED
            new TranslationEntry { TranslationId = 2, KeyId = 70, Value = "Megszakítva" }, // TAG_STATE_CANCELED

            // STATS
            new TranslationEntry { TranslationId = 2, KeyId = 283, Value = "Hiba a statisztikák betöltésekor" }, // STATS_LOAD_ERROR
            new TranslationEntry { TranslationId = 2, KeyId = 284, Value = "7 napos statisztika" }, // STATS_7_DAYS
            new TranslationEntry { TranslationId = 2, KeyId = 287, Value = "Úton/Megérkezett" }, // STATS_TRAVELING_LANDED
            new TranslationEntry { TranslationId = 2, KeyId = 289, Value = "Védelmek száma" }, // STATS_NUM_DVS
            new TranslationEntry { TranslationId = 2, KeyId = 290, Value = "Otthoni védelem" }, // STATS_DVS_AT_HOME
            new TranslationEntry { TranslationId = 2, KeyId = 291, Value = "Hátsó vonal védelem otthon" }, // STATS_BACKLINE_DVS_AT_HOME
            new TranslationEntry { TranslationId = 2, KeyId = 292, Value = "Úton lévő védelem" }, // STATS_DVS_TRAVELING

            // RANKINGS
            new TranslationEntry { TranslationId = 2, KeyId = 295, Value = "Hiba a toplista betöltésekor" }, // RANKINGS_LOAD_ERROR
            new TranslationEntry { TranslationId = 2, KeyId = 296, Value = "Toplista" }, // RANKINGS

            // TERMS
            new TranslationEntry { TranslationId = 2, KeyId = 299, Value = "Nem InnoGames" }, // TERMS_NOT_INNO
            new TranslationEntry { TranslationId = 2, KeyId = 300, Value = "Feltételek részletei" }, // TERMS_DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 6, Value = "Felhasználási feltételek" }, // TERMS_AND_CONDITIONS

            // TRANSLATIONS
            new TranslationEntry { TranslationId = 2, KeyId = 515, Value = "Nyelv" }, // TRANSLATION_LANGUAGE
            new TranslationEntry { TranslationId = 2, KeyId = 516, Value = "Fordítás" }, // TRANSLATION_TRANSLATION
            new TranslationEntry { TranslationId = 2, KeyId = 517, Value = "Beállítások mentése" }, // TRANSLATION_SAVE_SETTINGS
            new TranslationEntry { TranslationId = 2, KeyId = 518, Value = "Szerkesztés" }, // TRANSLATION_EDIT
            new TranslationEntry { TranslationId = 2, KeyId = 519, Value = "Új" }, // TRANSLATION_NEW
            new TranslationEntry { TranslationId = 2, KeyId = 520, Value = "Változtatások mentése" }, // TRANSLATION_SAVE_CHANGES
            new TranslationEntry { TranslationId = 2, KeyId = 521, Value = "Szerző" }, // TRANSLATION_AUTHOR
            new TranslationEntry { TranslationId = 2, KeyId = 522, Value = "Kulcs szerkesztése" }, // TRANSLATION_EDIT_KEY
            new TranslationEntry { TranslationId = 2, KeyId = 523, Value = "Érték szerkesztése" }, // TRANSLATION_EDIT_VALUE
            new TranslationEntry { TranslationId = 2, KeyId = 524, Value = "Minta" }, // TRANSLATION_EDIT_SAMPLE
            new TranslationEntry { TranslationId = 2, KeyId = 525, Value = "Hiányzó paraméterek" }, // TRANSLATION_EDIT_MISSING_PARAMS
            new TranslationEntry { TranslationId = 2, KeyId = 526, Value = "Pontos egyezés szükséges" }, // TRANSLATION_EDIT_NEEDS_EXACT
            new TranslationEntry { TranslationId = 2, KeyId = 527, Value = "Változtatások sikeresen mentve" }, // TRANSLATION_SAVE_CHANGES_SUCCESS
            new TranslationEntry { TranslationId = 2, KeyId = 528, Value = "Törlés" }, // TRANSLATION_DELETE
            new TranslationEntry { TranslationId = 2, KeyId = 529, Value = "Biztosan törlöd ezt a fordítást?" }, // TRANSLATION_DELETE_CONFIRM
            new TranslationEntry { TranslationId = 2, KeyId = 530, Value = "Az alapértelmezett fordítás nem törölhető" }, // TRANSLATION_DELETE_DEFAULT
            new TranslationEntry { TranslationId = 2, KeyId = 531, Value = "Nem mentve" }, // TRANSLATION_NOT_SAVED
            new TranslationEntry { TranslationId = 2, KeyId = 532, Value = "Fordítás törölve" }, // TRANSLATION_DELETED
            new TranslationEntry { TranslationId = 2, KeyId = 534, Value = "Másolat" }, // TRANSLATION_DUPLICATE
            new TranslationEntry { TranslationId = 2, KeyId = 535, Value = "Másolat készítése" }, // TRANSLATION_MAKING_COPY

            // GENERAL UI
            new TranslationEntry { TranslationId = 2, KeyId = 188, Value = "Dolgozom..." }, // WORKING
            new TranslationEntry { TranslationId = 2, KeyId = 201, Value = "Szkript letöltése" }, // GET_SCRIPT
            new TranslationEntry { TranslationId = 2, KeyId = 151, Value = "Tulajdonos" }, // OWNER
            new TranslationEntry { TranslationId = 2, KeyId = 155, Value = "Klán" }, // TRIBE
            new TranslationEntry { TranslationId = 2, KeyId = 163, Value = "Keresés" }, // SEARCH
            new TranslationEntry { TranslationId = 2, KeyId = 164, Value = "Eredmények" }, // RESULTS
            new TranslationEntry { TranslationId = 2, KeyId = 171, Value = "Törlés" }, // DELETE
            new TranslationEntry { TranslationId = 2, KeyId = 182, Value = "Kulcsok" }, // KEYS
            new TranslationEntry { TranslationId = 2, KeyId = 185, Value = "Felhasználónév" }, // USER_NAME
            new TranslationEntry { TranslationId = 2, KeyId = 194, Value = "Admin" }, // ADMIN
            new TranslationEntry { TranslationId = 2, KeyId = 198, Value = "Nincs klán" }, // NO_TRIBE
            new TranslationEntry { TranslationId = 2, KeyId = 216, Value = "Igen" }, // YES
            new TranslationEntry { TranslationId = 2, KeyId = 217, Value = "Játékos" }, // PLAYER
            new TranslationEntry { TranslationId = 2, KeyId = 304, Value = "Játékosok" }, // PLAYERS
            new TranslationEntry { TranslationId = 2, KeyId = 158, Value = "Nem található játékos" }, // NO_PLAYERS_FOUND
            new TranslationEntry { TranslationId = 2, KeyId = 186, Value = "Jelenlegi klán" }, // CURRENT_TRIBE
            new TranslationEntry { TranslationId = 2, KeyId = 191, Value = "Letöltés" }, // DOWNLOAD
            new TranslationEntry { TranslationId = 2, KeyId = 195, Value = "Esemény" }, // EVENT
            new TranslationEntry { TranslationId = 2, KeyId = 196, Value = "Idő" }, // TIME
            new TranslationEntry { TranslationId = 2, KeyId = 241, Value = "Szerver idő" }, // SERVER_TIME
            new TranslationEntry { TranslationId = 2, KeyId = 243, Value = "Üzenet" }, // MESSAGE
            new TranslationEntry { TranslationId = 2, KeyId = 244, Value = "Hozzáadás" }, // ADD
            new TranslationEntry { TranslationId = 2, KeyId = 264, Value = "Opcionális" }, // OPTIONAL
            new TranslationEntry { TranslationId = 2, KeyId = 268, Value = "Mentés" }, // SAVE
            new TranslationEntry { TranslationId = 2, KeyId = 52, Value = "Visszaállítás" }, // RESET
            new TranslationEntry { TranslationId = 2, KeyId = 60, Value = "Mégse" }, // CANCEL
            new TranslationEntry { TranslationId = 2, KeyId = 340, Value = "Részletek" }, // DETAILS
            new TranslationEntry { TranslationId = 2, KeyId = 336, Value = "Folyamat" }, // PROGRESS
            new TranslationEntry { TranslationId = 2, KeyId = 335, Value = "Feltöltés" }, // UPLOAD
            new TranslationEntry { TranslationId = 2, KeyId = 348, Value = "Összes feltöltése" }, // UPLOAD_ALL
            new TranslationEntry { TranslationId = 2, KeyId = 333, Value = "Várakozás" }, // WAITING
            new TranslationEntry { TranslationId = 2, KeyId = 27, Value = "Kész" }, // DONE
            new TranslationEntry { TranslationId = 2, KeyId = 547, Value = "Beállítások" }, // SETTINGS
            new TranslationEntry { TranslationId = 2, KeyId = 506, Value = "Előnézet" }, // PREVIEW
            new TranslationEntry { TranslationId = 2, KeyId = 494, Value = "Név" }, // NAME
            new TranslationEntry { TranslationId = 2, KeyId = 495, Value = "Opciók" }, // OPTIONS
            new TranslationEntry { TranslationId = 2, KeyId = 555, Value = "Pontok" }, // POINTS

            // COMMON GAME TERMS
            new TranslationEntry { TranslationId = 2, KeyId = 489, Value = "Támadás" }, // OFFENSE
            new TranslationEntry { TranslationId = 2, KeyId = 288, Value = "Védelem" }, // DEFENSE
            new TranslationEntry { TranslationId = 2, KeyId = 293, Value = "Támogatás" }, // SUPPORT
            new TranslationEntry { TranslationId = 2, KeyId = 20, Value = "Csapatok" }, // TROOPS
            new TranslationEntry { TranslationId = 2, KeyId = 285, Value = "Nuke-ok" }, // NUKES
            new TranslationEntry { TranslationId = 2, KeyId = 493, Value = "Nemesek" }, // NOBLES
            new TranslationEntry { TranslationId = 2, KeyId = 286, Value = "Fogak" }, // FANGS
            new TranslationEntry { TranslationId = 2, KeyId = 544, Value = "Fogak definíció" }, // FANGS_DEFINITION
            new TranslationEntry { TranslationId = 2, KeyId = 545, Value = "Úton lévő fogak" }, // FANGS_TRAVELING
            new TranslationEntry { TranslationId = 2, KeyId = 347, Value = "Parancsok" }, // COMMANDS
            new TranslationEntry { TranslationId = 2, KeyId = 342, Value = "Jelentések" }, // REPORTS
            new TranslationEntry { TranslationId = 2, KeyId = 128, Value = "Falu" }, // VILLAGE
            new TranslationEntry { TranslationId = 2, KeyId = 129, Value = "Hűség" }, // LOYALTY
            new TranslationEntry { TranslationId = 2, KeyId = 21, Value = "Kiindulási falu" }, // SOURCE_VILLAGE
            new TranslationEntry { TranslationId = 2, KeyId = 543, Value = "Célpont falu" }, // TARGET_VILLAGE
            new TranslationEntry { TranslationId = 2, KeyId = 22, Value = "Indítás ideje" }, // LAUNCH_TIME
            new TranslationEntry { TranslationId = 2, KeyId = 23, Value = "Érkezés ideje" }, // LANDING_TIME
            new TranslationEntry { TranslationId = 2, KeyId = 3, Value = "Érkezési idő" }, // ARRIVAL_TIME
            new TranslationEntry { TranslationId = 2, KeyId = 4, Value = "Érkezik" }, // ARRIVES_IN
            new TranslationEntry { TranslationId = 2, KeyId = 305, Value = "Klánok" }, // TRIBES
            new TranslationEntry { TranslationId = 2, KeyId = 306, Value = "Kontinensek" }, // CONTINENTS
            new TranslationEntry { TranslationId = 2, KeyId = 501, Value = "A te támogatásod innen" }, // YOUR_SUPPORT_FROM

            // ERROR MESSAGES
            new TranslationEntry { TranslationId = 2, KeyId = 439, Value = "Captcha aktiválva" }, // TRIGGERED_CAPTCHA
            new TranslationEntry { TranslationId = 2, KeyId = 334, Value = "Váratlan hiba" }, // UNEXPECTED_ERROR
            new TranslationEntry { TranslationId = 2, KeyId = 392, Value = "Feltöltési hiba" }, // UPLOAD_ERROR
            new TranslationEntry { TranslationId = 2, KeyId = 17, Value = "Hiba történt" }, // ERROR_OCCURRED
            new TranslationEntry { TranslationId = 2, KeyId = 62, Value = "Nem szám" }, // NOT_A_NUMBER
            new TranslationEntry { TranslationId = 2, KeyId = 64, Value = "Nincs kijelölt bejövő" }, // NO_INCOMINGS_SELECTED
            new TranslationEntry { TranslationId = 2, KeyId = 18, Value = "Nincs elérhető parancs" }, // NO_COMMANDS_AVAILABLE
            new TranslationEntry { TranslationId = 2, KeyId = 19, Value = "Nincs elérhető adat" }, // NO_DATA_AVAILABLE

            // UPLOAD DESCRIPTIONS
            new TranslationEntry { TranslationId = 2, KeyId = 341, Value = "Feltöltés leírása" }, // UPLOAD_DESCRIPTION
            new TranslationEntry { TranslationId = 2, KeyId = 328, Value = "Jelentések feltöltése" }, // UPLOAD_DESCRIPTION_REPORTS
            new TranslationEntry { TranslationId = 2, KeyId = 329, Value = "Bejövők feltöltése" }, // UPLOAD_DESCRIPTION_INCS
            new TranslationEntry { TranslationId = 2, KeyId = 330, Value = "Parancsok feltöltése" }, // UPLOAD_DESCRIPTION_COMMANDS
            new TranslationEntry { TranslationId = 2, KeyId = 331, Value = "Csapatok feltöltése" }, // UPLOAD_DESCRIPTION_TROOPS
            new TranslationEntry { TranslationId = 2, KeyId = 332, Value = "Gyorsítótár törölve" }, // UPLOAD_CACHE_CLEARED
            new TranslationEntry { TranslationId = 2, KeyId = 349, Value = "Gyorsítótár törlése" }, // UPLOAD_CLEAR_CACHE
            new TranslationEntry { TranslationId = 2, KeyId = 12, Value = "Parancsok feltöltése szükséges" }, // UPLOAD_COMMANDS_REQUIRED
            new TranslationEntry { TranslationId = 2, KeyId = 13, Value = "Bejövők feltöltése szükséges" }, // UPLOAD_INCOMINGS_REQUIRED
            new TranslationEntry { TranslationId = 2, KeyId = 14, Value = "Jelentések feltöltése szükséges" }, // UPLOAD_REPORTS_REQUIRED
            new TranslationEntry { TranslationId = 2, KeyId = 15, Value = "Csapatok feltöltése szükséges" }, // UPLOAD_TROOPS_REQUIRED
            new TranslationEntry { TranslationId = 2, KeyId = 16, Value = "Adatok feltöltése szükséges az alábbi okok miatt" }, // UPLOAD_DATA_REQUIRED_REASONS
            new TranslationEntry { TranslationId = 2, KeyId = 32, Value = "Látható bejövők feltöltése" }, // UPLOAD_VISIBLE_INCOMINGS
            new TranslationEntry { TranslationId = 2, KeyId = 28, Value = "Feltöltés folytatódik ha bezárod" }, // UPLOADING_IF_CLOSED

            // SCRIPT MESSAGES
            new TranslationEntry { TranslationId = 2, KeyId = 5, Value = "Prémium fiók szükséges" }, // REQUIRE_PREMIUM_ACCOUNT
            new TranslationEntry { TranslationId = 2, KeyId = 7, Value = "Szkript újrafuttatása" }, // RE_RUN_SCRIPT
            new TranslationEntry { TranslationId = 2, KeyId = 8, Value = "A szkript nem futott" }, // SCRIPT_NOT_RAN
            new TranslationEntry { TranslationId = 2, KeyId = 9, Value = "Frissítési értesítés" }, // UPDATE_NOTICE
            new TranslationEntry { TranslationId = 2, KeyId = 31, Value = "Ez a funkció kísérleti" }, // FEATURE_IS_EXPERIMENTAL
            new TranslationEntry { TranslationId = 2, KeyId = 2, Value = "Vault megnyitása" }, // OPEN_VAULT
            new TranslationEntry { TranslationId = 2, KeyId = 25, Value = "Vault" }, // VAULT
            new TranslationEntry { TranslationId = 2, KeyId = 26, Value = "Vault felület leírása" }, // VAULT_INTERFACE_DESCRIPTION

            // BB CODES
            new TranslationEntry { TranslationId = 2, KeyId = 438, Value = "BB táblázat" }, // BB_TABLE
            new TranslationEntry { TranslationId = 2, KeyId = 511, Value = "BB egység" }, // BB_UNIT
            new TranslationEntry { TranslationId = 2, KeyId = 512, Value = "BB URL" }, // BB_URL

            // OTHER
            new TranslationEntry { TranslationId = 2, KeyId = 440, Value = "Csoportban van" }, // IS_IN_GROUP
            new TranslationEntry { TranslationId = 2, KeyId = 441, Value = "Szűrő alkalmazva" }, // FILTER_APPLIED
            new TranslationEntry { TranslationId = 2, KeyId = 448, Value = "Rendezett hónapok" }, // ORDERED_MONTHS
            new TranslationEntry { TranslationId = 2, KeyId = 74, Value = "Talán nuke" }, // MAYBE_NUKE
            new TranslationEntry { TranslationId = 2, KeyId = 71, Value = "Ismeretlen" }, // UNKNOWN
            new TranslationEntry { TranslationId = 2, KeyId = 488, Value = "Nincs" }, // NONE
            new TranslationEntry { TranslationId = 2, KeyId = 24, Value = "Egység szükséges" }, // TROOP_REQUIRED
            new TranslationEntry { TranslationId = 2, KeyId = 65, Value = "A címkék naprakészek" }, // TAGS_ARE_CURRENT
            new TranslationEntry { TranslationId = 2, KeyId = 462, Value = "Statisztika kérése" }, // REQUEST_STATS
            new TranslationEntry { TranslationId = 2, KeyId = 220, Value = "Lehetséges nemesek" }, // POSSIBLE_NOBLES

            // MISSING - BASIC UI LABELS
            new TranslationEntry { TranslationId = 2, KeyId = 12, Value = "parancsok" }, // COMMANDS
            new TranslationEntry { TranslationId = 2, KeyId = 13, Value = "bejövők" }, // INCOMINGS
            new TranslationEntry { TranslationId = 2, KeyId = 14, Value = "jelentések" }, // REPORTS
            new TranslationEntry { TranslationId = 2, KeyId = 15, Value = "csapatok" }, // TROOPS
            new TranslationEntry { TranslationId = 2, KeyId = 16, Value = "Feltöltés szükséges:" }, // UPLOAD_NEEDED
        };
    }
}