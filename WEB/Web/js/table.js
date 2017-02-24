function TableCtrl(tableId){
  var obj = document.getElementById(tableId);
  if(obj != null)
  {
      this.table = obj;
  }
  else
  {
    return null;
  } 
}

TableCtrl.prototype = {
  reset:function(){
   	if (this.table == null) return;
   	var trs = this.table.getElementsByTagName("tr");
   	for (var i = 1; i < trs.length; ){
	    trs[i].parentNode.removeChild(trs[i]);
	}
  },
  getNumOfRows:function(){
  return this.table.rows.length;
  },
  addRows:function(rowIndex,numOfCols,contents){
  	if (this.table == null) return 0 ;
   	if((rowIndex < 0) ||(rowIndex > this.getNumOfRows())) return 0;
   	var newRow = this.table.insertRow(rowIndex + 1);
	  for(var i=0;i<numOfCols;i++){
    	newRow.insertCell(i);	 
    	if (contents[i] != null)
    	{
	   		newRow.cells[i].innerHTML = contents[i];
	   	}
	  }
	return 1;
  },
  addMultiRows:function(startRowIndex,numOfCols,contents){
	  var rows = contents.length / numOfCols;
	  if (this.table == null) return 0;
   	  if((startRowIndex < 0) ||(startRowIndex > this.getNumOfRows())) return 0;
	  
	  for (var i = 0; i < rows; i++){
		  var newRow = this.table.insertRow(startRowIndex + i + 1);
		  
		  for (var j =0 ; j < numOfCols; j++)
		  {   
		      newRow.insertCell(j);
			  newRow.cells[j].innerHTML = contents[i * numOfCols + j];
		  }
	  }
	  
	  return rows;
  }
}
