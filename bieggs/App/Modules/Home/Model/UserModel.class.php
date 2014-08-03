<?php
class UserModel extends Model {
    
    public function getSelfInfo(){
        $ID = $_SESSION[C('USER_AUTH_KEY')];
        return $this->where('id='.$ID)->find();
    }

    public function getUserSet(){
        $userMsg = $this->getSelfInfo();
        foreach ($userMsg as $k => $v) {
        	Log::record($k.'=>'.$v);
        	if ($this->isAttrHide($k)) {
        		Log::record("-----hidek = " . $k);
        		if ("" != $userMsg[$k]) {
        			$userMsg[$k] = "1";
        		}
        	}
        }
        return $userMsg;
    }

    private function isAttrHide($attr){
    	$u_hide=array("key","s_key","phone","qq","s_name","s_number","s_message","s_bankkey"); //用户不可外显得信息
		for($x=0;$x<count($u_hide);$x++) {
		  if ($u_hide[$x] == $attr) {
		  	return true;
		  };
		}
		return false;
    }

    public function updateField($field,$value){
        $ID = $_SESSION[C('USER_AUTH_KEY')];
        $this-> where('id='.$ID)->setField($field,$value);
    }

}