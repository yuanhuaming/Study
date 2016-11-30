        public Task(Action action);
        public Task(Action<object> action, object state);
        public Task(Action action, CancellationToken cancellationToken);
        public Task(Action action, TaskCreationOptions creationOptions);
        public Task(Action<object> action, object state, CancellationToken cancellationToken);
        public Task(Action<object> action, object state, TaskCreationOptions creationOptions);
        public Task(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions);
        public Task(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions);