//$(document).ready(function () {
$(document).ready(function () {
    // alert("!!!");
});


function likeunlike(newsID) {
    //var newsID = $('#hNewsID').val();
    var likeunlike = $('#likeunlike_' + newsID).val();
    $.ajax({
        url: "/members/news/updateLike",
        type: "POST",
        data: JSON.stringify({ 'newsID': newsID, 'likeunlike': likeunlike }),
        dataType: "json",
        traditional: true,
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            if (data.status == "Success") {
                // alert("Done");
                $('#' + newsID).html(" likes(" + data.like + ")");
                if (likeunlike == "unlike") {
                    $('#likeunlike_' + newsID).val("like")
                }
                else {
                    $('#likeunlike_' + newsID).val("unlike")
                }
            } else {
                alert("Error occurs on the Database level!");
            }
        },
        error: function () {
            alert("An error has occured!!!");
        }
    });
};



function AddComments(newsID) {
    //var newsID = $('#hNewsID').val();
    var Comment = $('#txtComments').val();
    $.ajax({
        url: "/members/news/AddComments",
        type: "POST",
        data: JSON.stringify({ 'newsID': newsID, 'Comment': Comment }),
        dataType: "json",
        traditional: true,
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            if (data.status == "Success") {
                // alert("Done");
                $('#' + newsID).html(" likes(" + data.like + ")");
                if (likeunlike == "unlike") {
                    $('#likeunlike_' + newsID).val("like")
                }
                else {
                    $('#likeunlike_' + newsID).val("unlike")
                }
            } else {
                alert("Error occurs on the Database level!");
            }
        },
        error: function () {
            alert("An error has occured!!!");
        }
    });
};