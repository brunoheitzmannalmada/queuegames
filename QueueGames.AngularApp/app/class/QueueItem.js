﻿function QueueItem(field1, field2, post, successCallback, errorCallback) {
    var queueItem = this;
    this.field1 = field1;
    this.field2 = field2;
    this.status = 1;
    this.sCallback = successCallback;
    this.eCallback = errorCallback;

    post.then(function successCallback(response) {
        queueItem.status = 2;
        queueItem.sCallback();
    }, function errorCallback(response) {
        queueItem.status = 3;
        queueItem.eCallback();
    });

    return this;
};