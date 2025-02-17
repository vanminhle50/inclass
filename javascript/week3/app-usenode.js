const fs = require('node:fs');
const data ="This is a string that we are going in to write to file";
console.log("Writing to file");
fs.writeFile('output.txt', data,(err)=>{
    if (err){
        console.log(err);
    }else{
            console.log("File written successfully");
        }
    }
);
console.log("Reading from file");

fs.readFile("output.txt",(err,fileText)=>{
    if(err){
        console.error(err);
        return;
    }
    console.log("The file content are: ");
    console.log(fileText.toString());
});
