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

}