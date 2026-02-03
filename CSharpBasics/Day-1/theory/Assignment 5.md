# Assignment 5

1. **Why Nullable Types Were Introduced**

Nullable types were introduced to allow value types (like int, bool, or Datetime) to represent a "no value" or "unknown" state, which they cannot naturally do because they have mandatory default values.

1. **Scenarios where nullable types are preferred**
- **Database Integration:** Mapping table columns that allow NULL values to C# variables ensures your application accurately reflects missing data from a database.
- **Web API & JSON Data:** Handling optional properties in JSON requests where a field might be omitted or explicitly sent as null by a client.
- **Logical States:** Representing three-state logic (e.g., a "Yes/No" survey where a user hasn't answered yet can be stored as a **bool?** with states  true , false, or null).