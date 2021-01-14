<?php
$data = json_decode(file_get_contents("http://localhost:8080/airlines/data/data.json"), true);
print_r($data);
echo "<br>";
for($i=0; $i<count( $data );$i++){
	echo $data[$i]["name"]."<br>";
}

?>