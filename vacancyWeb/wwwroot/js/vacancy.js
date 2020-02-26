var fillList = function () {
    var list = [];
    var httpReq = new XMLHttpRequest();
    httpReq.open("GET", "home/GetAllVacansies", true);
    httpReq.onload = function (e) {
        console.log('status: ' + httpReq.status);
        if (httpReq.status != 200) {
            console.log('error status:' + httpReq.status);
        }
        else {
            console.log('json:' + httpReq.response)
            var data = JSON.parse(httpReq.response);
            console.log('parsed:' + data.length);
            var table = document.getElementById('listvacansies');
            for (var i = 0; i < data.length; i++) {
                console.log('i' + i);
                console.log('row:' + i + 't:' + data[i].title + 'd:' + data[i].date);
                var row = table.insertRow();
                var cellTitle = row.insertCell(0);
                var content = document.createTextNode(data[i].title);
                cellTitle.appendChild(content);
                var cellDate = row.insertCell(1);
                content = document.createTextNode(data[i].date);
                cellDate.appendChild(content);
            }


        }



    };
    httpReq.onerror = function (e) {
        console.error(httpReq.statusText);
    };
    httpReq.send();

};

fillList();
document.styleSheets[0].disabled = false;
document.styleSheets[1].disabled = false;