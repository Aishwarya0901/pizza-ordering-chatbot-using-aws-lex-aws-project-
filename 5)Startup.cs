…
    // Create the storage we'll be using for User and Conversation state. (Memory is great for testing purposes.) 
    // Added Local Memory Storage for the user to simulate a DB or longer running store
    services.AddSingleton<IStorage, MemoryStorage>();

    // Create the User state. 
    // Added to store UserState which is about the user and longer lived
    services.AddSingleton<UserState>();

    // Create the Conversation state.
    // Added ConversationState to store local data for immediate conversation
    services.AddSingleton<ConversationState>();

...
