var idRow;
var preEl;
var orgBColor;
var orgTColor;
function HighLightTR(id, el, backColor, textColor) {
    idRow = id;

    if (typeof (preEl) != 'undefined') {
        preEl.bgColor = orgBColor;
        try { ChangeTextColor(preEl, orgTColor); } catch (e) { ; }
    }
    orgBColor = el.bgColor;
    orgTColor = el.style.color;
    el.bgColor = backColor;

    try { ChangeTextColor(el, textColor); } catch (e) { ; }
    preEl = el;
}


function ChangeTextColor(a_obj, a_color) {
    ;
    for (i = 0; i < a_obj.cells.length; i++)
        a_obj.cells(i).style.color = a_color;
}

function jaja () {
    console.log("jaja");
    $.ajax({
        type: "GET",
        url: 'Item/Edit/?id=2" })',
        contentType: "application/json; charset=utf-8",
        data: {"id": "idRow"},
        dataType: "json",
        success: function (recData) { alert('Success'); },
        error: function () { alert('A error'); }
    });
};