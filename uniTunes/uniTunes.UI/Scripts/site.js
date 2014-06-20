
    $(document).ready(function () {

        // Search - Inicio
        $('a[href="#search"]').on('click', function (event) {
            event.preventDefault();
            $('#search').addClass('open');
            $('#search > form > input[type="search"]').focus();
        });

        $('#search, #search button.close').on('click keyup', function (event) {
            if (event.target == this || event.target.className == 'close' || event.keyCode == 27) {
                $(this).removeClass('open');
            }
        });
        // Search - Fim

        $('#shopping-cart').click(function () {
            var url = "/Media/ShoppingCart";
            $.get(url, function (data) {
                $('#header-modal-body').html(data);
                $('#header-modal').modal('show');
            });
        });

        $('#help-support').click(function () {
            var url = "/Help/Support";
            $.get(url, function (data) {
                $('#header-modal-body').html(data);
                $('#header-modal').modal('show');
            });
        });

        $('#user-messages').click(function () {
            var url = "Profile/Messages";
            $.get(url, function (data) {
                $('#header-modal-body').html(data);
                $('#header-modal').modal('show');
            });
        });

        $('#help-contact').click(function () {
            var url = "/Help/Contact";
            $.get(url, function (data) {
                $('#header-modal-body').html(data);
                $('#header-modal').modal('show');
            });
        });

        $('#user-preferences').click(function () {
            var url = "/Profile/Preferences";
            $.get(url, function (data) {
                $('#header-modal-body').html(data);
                $('#header-modal').modal('show');
            });
        });

    });
