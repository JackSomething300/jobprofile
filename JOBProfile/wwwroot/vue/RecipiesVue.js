var RecipiesBar = new Vue({
    el: '#recipiesMenu',
    data: {
        InitialRecipies: [],
    },
    mounted: function () {
        var self = this;
        self.InitialLoad();
    },
    methods: {
        InitialLoad: function () {
            var self = this;
            $.ajax({
                type: 'post',
                url: '/search/getallrecipies',
                dataType: "json",
                contentType: 'application/json',
                success: function (data) {
                    if (data !== null) {
                        self.InitialRecipies = data;
                    }
                },
                error: function (result) {
                    console.log('There was an error retrieving aggs');
                }
            });
        }
    }
});