function QueueItem(field1, field2, post) {
    var queueItem = this;
    this.field1 = field1;
    this.field2 = field2;
    this.status = 1;

    post.then(function successCallback(response) {
        queueItem.status = 2;
    }, function errorCallback(response) {
        queueItem.status = 3;
    });

    return this;
};