<?php
class InviteModel extends Model {
	const PERPAGE = 10;

    public function getMyInvite(){
        $UID = $_SESSION[C('USER_AUTH_KEY')];
        if (isNil($UID)) {
            return null;
        }
        return $this->where("UID=".$UID)->find();
    }

    //获得最高10位得分者
    public function top10(){
        return $this->order('score DESC')->limit(10)->select();
    }

    //获得最新10位得分者
    public function newer10(){
        return $this->order('CTIME DESC')->limit(10)->select();
    }

    //更新某一位最后得分
    public function updateByUID($UID,$BUID,$last_score){
        $exist = $this->where("UID=".$UID)-find();
        $data = Array();
        $data["UID"] = $UID;
        $data["last_score"] = $last_score;
        $data["CTIME"] = time();
        if ($exist) { //用户已经存在的情况
            $data["BUIDS"] = $exist["BUIDS"] . "," . $BUID;
            $data["b_num"] = $exist["b_num"] + 1;
            $data["score"] = $exist["score"] + $last_score;
            $this->where("UID=".$UID)->save($data);
        }else {  //用户还不存在
            $data["BUIDS"] = $BUID;
            $data["b_num"] = 1;
            $data["score"] = $last_score;
            $this->add($data);
        }
    }

}