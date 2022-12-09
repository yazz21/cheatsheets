# For selecting phrases, use double quotes like:
    For details, see CONTAINS [contains] ( https://learn.microsoft.com/en-us/sql/t-sql/queries/contains-transact-sql?view=sql-server-ver16 "contains")

```sql
    SELECT * FROM MyTable WHERE Column1 CONTAINS '"Phrase one" And word2 And "Phrase Two"'
```
P.S.: You have to first enable Full Text Search on the table before using contains keyword. For more details, see [ Get Started with Full-Text Search ] (https://learn.microsoft.com/en-us/sql/relational-databases/search/get-started-with-full-text-search?view=sql-server-ver16 "full-text-search")