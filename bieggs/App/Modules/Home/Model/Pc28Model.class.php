<?php
class Pc28Model extends Model {
    const PERPAGE = 20;
    public function getResultByPage($page = 1){
        if (is_nil($page)) {
            $page = 1;
        }
        return $this->order('id DESC')->page($page,$this::PERPAGE)->select();
    }

    public function getLastRecord($filed){
        return $this->order('id DESC')->field($filed)->limit(5,1)->select();
    }

    public function getCount(){
        return $this->count();
    }
}