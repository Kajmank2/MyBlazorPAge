function saveMessage(name, model) {
    //alert(Name +' '+ Model + 'Record has been saved sucesfully!');
    document.getElementById('divServerValidations').innerText = name + ' ' + model + 'Record has been saved sucesfully!'
}
function setFocusOnElemt(element) {
    element.focus();
}
function getKind() {
    var Kind = ['Diesel', 'Petrol', 'Petrol+Lpg'];
    return Kind;
}