using System.Collections.Generic;

namespace CH3.DesignForChange;

public interface IDatabaseOperations<TEntity>
{
    // Open the database connection.
    void OpenConenction();

    // Close the database connection.
    void CloseConnection();

    // Create a new entity in the database
    void Create(TEntity entity);

    // Read a single entity from the database by its unique identifier
    TEntity ReadById(int id);

    // Read all entities from the database
    IEnumerable<TEntity> ReadAll();

    // Update an existing entity in the database
    void Update(TEntity entity);

    // Delete an entity from the database
    void Delete(TEntity entity);
}