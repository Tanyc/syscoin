<?php
class Pc310Model extends Model {

    public function getResult($page = 1){
        return $this->field(true)->limit(20)->select();
    }

}