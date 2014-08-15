<?php
//参考文献：http://www.nowamagic.net/academy/detail/12220211
/******************php以六种方式获取第三方网络数据1********************/
/*$url = 'http://www.nowamagic.net/php/sock.php';
$html = file_get_contents($url);
echo $html;*/
/******************php以六种方式获取第三方网络数据2********************/
/*$url = 'http://www.nowamagic.net/php/sock.php';
$fp = fopen($url, 'r');
stream_get_meta_data($fp);
$result = '';
while(!feof($fp))
{
    $result .= fgets($fp, 1024);
}
echo "url body: $result";
fclose($fp);*/
/******************php以六种方式获取第三方网络数据3********************/
/*$data = array(
    'foo'=>'bar',
    'baz'=>'boom',
    'site'=>'www.nowamagic.net',
    'name'=>'nowa magic');
$data = http_build_query($data);
//$postdata = http_build_query($data);
$options = array(
    'http' => array(
        'method' => 'POST',
        'header' => 'Content-type:application/x-www-form-urlencoded',
        'content' => $data
        //'timeout' => 60 * 60 // 超时时间（单位:s）
    )
);
$url = "http://www.nowamagic.net/php/sock.php";
$context = stream_context_create($options);
$result = file_get_contents($url, false, $context);
echo $result;*/
/******************php以六种方式获取第三方网络数据4********************/
/*$url = 'http://www.nowamagic.net:80/php/sock.php?site=nowamagic.net';
function get_url($url,$cookie=false)
{
    $url = parse_url($url);
    $query = $url['path']."?".$url['query'];
    echo "Query:".$query;
    $fp = fsockopen( $url['host'], $url['port']?$url['port']:80 , $errno, $errstr, 30);
    if (!$fp)
    {
        return false;
    }
    else {
        $request = "GET $query HTTP/1.1\r\n";
        $request .= "Host: $url[host]\r\n";
        $request .= "Connection: Close\r\n";
        if($cookie) $request.="Cookie:   $cookie\n";
        $request.="\r\n";
        fwrite($fp,$request);
        $result = '';
        while(!feof($fp))
        {
            $result .= @fgets($fp, 1024);
        }
        fclose($fp);
        return $result;
    }
}
//获取url的html部分，去掉header
function GetUrlHTML($url,$cookie=false)
{
    $rowdata = get_url($url,$cookie);
    if($rowdata)
    {
        $body= stristr($rowdata,"\r\n\r\n");
        $body=substr($body,4,strlen($body));
        return $body;
    }
    return false;
}
echo get_url($url);
echo GetUrlHTML($url);*/
/******************php以六种方式获取第三方网络数据5********************/
/*$url = 'http://www.nowamagic.net:80/php/sock.php?site=nowamagic.net';
function HTTP_Post($URL,$data,$cookie, $referer="")
{
    // parsing the given URL
    $URL_Info=parse_url($URL);
    // Building referrer
    if($referer=="") // if not given use this script as referrer
        $referer="www.nowamagic.net";
    // making string from $data
    foreach($data as $key=> $value)
    $values[]="$key=".urlencode($value);
    $data_string=implode("&",$values);
    // Find out which port is needed - if not given use standard (=80)
    if(!isset($URL_Info["port"]))
        $URL_Info["port"]=80;
    $request = '';
    // building POST-request:
    $request.="POST ".$URL_Info["path"]." HTTP/1.1\n";
    $request.="Host: ".$URL_Info["host"]."\n";
    $request.="Referer: $referer\n";
    $request.="Content-type: application/x-www-form-urlencoded\n";
    $request.="Content-length: ".strlen($data_string)."\n";
    $request.="Connection: close\n";
    $request.="Cookie:   $cookie\n";
    $request.="\n";
    $request.=$data_string."\n";
    $fp = fsockopen($URL_Info["host"],$URL_Info["port"]);
    fputs($fp, $request);
    $result = '';
    while(!feof($fp))
    {
        $result .= fgets($fp, 1024);
    }
    fclose($fp);
    return $result;
}
$data = array(
    'foo'=>'bar',
    'baz'=>'boom',
    'site'=>'www.nowamagic.net',
    'name'=>'nowa magic');
$cookie = '';
$referer = 'http://www.nowamagic.net/';
echo HTTP_Post($url, $data, $cookie, $referer);*/
/******************php以六种方式获取第三方网络数据6********************/
//此种方式需要检查php.ini文件中的curl支持是否开启
$url = 'http://www.nowamagic.net:80/php/sock.php?site=nowamagic.net';
$ch = curl_init();
$timeout = 5;
curl_setopt ($ch, CURLOPT_URL, $url);
curl_setopt ($ch, CURLOPT_RETURNTRANSFER, 1);
curl_setopt ($ch, CURLOPT_CONNECTTIMEOUT, $timeout);
$file_contents = curl_exec($ch);
curl_close($ch);
echo $file_contents;

?>