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

function editRow() {
    window.open(linkEdit + '/' + idRow);
};
function deleteRow() {
    window.open(linkDelete + '/' + idRow);
};