<?php
class BbsModel extends Model {
	const PERPAGE = 10;

    public function getPageResultByType($type,$page){
        return $this->where("type=".$type)->page($page,$this::PERPAGE)->select();
    }

    public function getCountByType($type){
        return $this->where("type=".$type)->count();
    } 

    public function getResultById($id){
        return $this->where("id=".$id)->find();
    }

    public function addOneItem($data){
        return $this->add($data);
    }

    public function ansNumPlus($id){
        $re = $this->where("id=".$id)->find();
        if ($re) {
            $ans_num = $re["ans_num"] + 1;
            $this->where("id=".$id)->setField('ans_num',$ans_num);
        }
    }

    public function ansNumSub($id){
        $re = $this->where("id=".$id)->find();
        if ($re) {
            $ans_num = $re["ans_num"] - 1 >= 0 ? $re["ans_num"] - 1 : 0;
            $this->where("id=".$id)->setField('ans_num',$ans_num);
        }
    }

}