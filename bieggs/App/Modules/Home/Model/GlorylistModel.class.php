<?php
class GlorylistModel extends Model {
	const PERPAGE = 10;
	public function getResultByPage($page = 1,$isMy){
        $UID = $_SESSION[C('USER_AUTH_KEY')];
        if ($isMy) {
            return $this->where("UID=".$UID)->page($page,$this::PERPAGE)->select();
        }
        return $this->page($page,$this::PERPAGE)->select();
    }

    public function getMyResultByPage($page){
        $page = $page? $page : 1;
        return $this->getResultByPage($page,true);
    }

    public function getAllResultByPage($page){
        $page = $page? $page : 1;
        return $this->getResultByPage($page);
    }

    public function getAllCount(){
        return $this->count();
    }

    public function getMyCount(){
        $UID = $_SESSION[C('USER_AUTH_KEY')];
        return $this->where("UID=".$UID)->count();
    }

    public function getResultById($id){
        $result = $this->where("id=".$id)->find();
        return $result;
    }

    public function getFiledById($id,$field){
        $result = $this->where("id=".$id)->find();
        return $result[$field];
    }

    public function updateFiledById($id,$field,$value){
        $result = $this->where("id=".$id)->setField($field,$value);
    }
    public function addZan($id){
        $dian = $this->getFiledById($id,"yes");
        $this->updateFiledById($id,"yes",$dian + 1);
    }
}