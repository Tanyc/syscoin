<?php
class UserModel extends Model {

    public function getAuthInfo(){
        $ID = $_SESSION[C('USER_AUTH_KEY')];
        return $this-> where('id='.$ID)->find();
    }

    public function getUserSet(){
        $userMsg = $this->getAuthInfo();
        foreach ($userMsg as $k => $v) {
        	if ($this->isAttrHide($k)) {
        		if ("" != $userMsg[$k]) {
        			$userMsg[$k] = "1";
        		}
        	}
        }
        return $userMsg;
    }

    private function isAttrHide($attr){
    	$u_hide=array("key","s_key","s_name","s_number","s_bankkey"); //lift user info
		for($x=0;$x<count($u_hide);$x++) {
		  if ($u_hide[$x] == $attr) {
		  	return true;
		  };
		}
		return false;
    }

    public function updateField($field,$value){
        $ID = $_SESSION[C('USER_AUTH_KEY')];
        return $this->where('id='.$ID)->setField($field,$value);
    }

    public function updateFields($datas){
        $ID = $_SESSION[C('USER_AUTH_KEY')];
        return $this->where('id='.$ID)->data($datas)->save();
    }

    public function getFiledByUID($UID,$field){
        $result = $this->where("id=".$UID)->find();
        return $result[$field];
    }

    //根据条件查询被邀请好友的信息
    public function getInviteUsersByCon($con){
        $fields = "id,status,nick,vip,ltime,reTIME,tui_score";
        return $this->where($con)->getField($fields);
    }

}