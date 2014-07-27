<?php
class UserModel extends Model {
    
    public function getUserByid($ID){
        return $this->where('user_id='.$ID)->find();
    }

    public function getUserSet($ID){
        $userMsg = $this->getUserByid($ID);
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
        $u_id = 1873372;
        $this-> where('user_id='.$u_id)->setField($field,$value);
    }

}