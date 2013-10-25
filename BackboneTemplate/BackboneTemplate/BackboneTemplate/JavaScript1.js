var ViewName = Backbone.View.extend({
    tagName: 'div',
    className: '',

    events: {
        "click": "onClick" // register your event here.
    },

    initialize: function() {
    },

    render: function() {
        var jsonModel = this.model.toJson();
        
    },

    onClick: function() {
    }
});