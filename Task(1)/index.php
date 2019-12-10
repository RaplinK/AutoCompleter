<?php
$people =  simplexml_load_file("Autocompleter.xml");
$form = "Мужской";
if(isset($_GET['x'])){
    switch ($_GET['x']) {
        case 'мужчины':
            $form = "Мужской";
            break;
        case 'женщины':
            $form = "Женский";
    }
}
function searchPeopleByName($query) {
   global $people;
    $result = array();
    foreach($people  as  $peoples)
        if (substr(strtolower($peoples -> name), 0, strlen($query)) == strtolower($query)){
            array_push($result, $peoples);
        }
    return $result;
}
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
	<title>Автозаполнитель</title>
</head>
<body>

	<h1>Автозаполнитель</h1>
	<b>Первое имя:</b>
	        <?php
        echo $people -> people[0] -> name;
        ?>
		<br/>
		<b>Послднее имя:</b>
	            <?php
            $var_people=$people->xpath('/peoples/people[last()]/name')[0];
            echo $var_people;
            ?>
	<table border="1">		
		<tr>
			<th>Имя</th>
			<th>Пол</th>
			<th>Имя на родном языке</th>
			<th>Имя на иностранном языке</th>
		</tr>
		<?php
		foreach($people->people as $peoples){
		echo "<tr>";
		echo "<td>".($peoples -> name)."</td>";
		echo "<td>".($peoples -> gender)."</td>";
		echo "<td>".($peoples -> nativeName)."</td>";
		echo "<td>".($peoples -> fln)."</td>";
		echo "</tr>";
		}
		?>
	</table>

	<br/>
	<table border="1">
	<a href="index.php?x=мужчины"><h3>Мужчины</h3></a>
	<a href="index.php?x=женщины"><h3>Женщины</h3></a>
	<tr>
		<th>Имя</th>
		<th>Пол</th>
		<th>Имя на родном языке</th>
		<th>Имя на иностранном языке</th>
	</tr>
	<?php
	foreach($people->people as $peoples){
		if($peoples->gender == $form){
			echo "<tr>";
			echo "<td>".($peoples->name)."</td>";
			echo "<td>".($peoples->gender)."</td>";
			echo "<td>".($peoples->nativeName)."</td>";
			echo "<td>".($peoples->fln)."</td>";
			echo "</tr>";
		}
    }
    ?>
	</table>
    </div>

	<br/>
	<form action="?" method="post">
		Поиск: <input type="text" name="search" placeholder=""/>
		<input type="submit" value="Найти"/>
    </form>
	<table border="1">
	        <tr>
        <th>Имя</th>
        <th>Пол</th>
        <th>Имя на родном языке</th>
        <th>Имя на иностранном языке</th>
    </tr>
	<?php
    if(!empty($_POST["search"]))
    {    
		$result = searchPeopleByName($_POST["search"]);
		foreach($result as $peoples){
		echo "<tr>";
		echo "<th>".($peoples -> name)."</th>";
		echo "<th>".($peoples -> gender)."</th>";
		echo "<th>".($peoples -> nativeName)."</th>";
		echo "<th>".($peoples -> fln)."</th>";
		echo "</tr>";
		}
	}
	?>
	</table>

</body>
</html>