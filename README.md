# Legion Prototype

# Confidential - Authorized personnel only

This prototype represents a classified Legion project to aid in defense of the city and ensure continued cooperation
amongst the guilds. Any unauthorized access to this code represents potential security risks from other guilds and
jeopardizes everyone's safety.

Remember: **Anyone** can be a House spy. Do not show to anyone for any reason not explicitly allowed and not before
enacting appropriate authorization protocols.

## Solution Layout

General folders:

* Interfaces - Interfaces for the classes in the relevant area.
* Requests - POCOs representing requests made between projects.
* Responses - POCOs representing responses returned from calls made between projects.

Solution structure:

* CityOfGuilds.Legion.Core - Core objects and methods referenced by two or more other projects.
    * BadLuckProtection - Classes and methods for interacting with the Bad Luck Protection (BLP) system.
        * Retrievers - Classes that return BLP information.
        * Updaters - Classes to update BLP information.
    * Enum - Constant enumeration values used throughout the solution.
    * Object - POCOs representing different types of objects.
        * Armor - Objects relating to types of armor.
        * Equipment - Objects relating to equipment.
        * Weapon - Objects relating to types of weapons.
    * Repository (Internal) - Classes for accessing the back-end data. ❗**Should not be directly
      exposed to other projects.**
* CityOfGuilds.Legion.Data - Data entities and context for the back-end database.
* CityOfGuilds.Legion.Item - Objects and methods related to items.
