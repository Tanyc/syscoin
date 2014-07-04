<?php
class UserBets310Model extends Model {
    
    public function getDataByLid($LID){
        return $this->where('LID='.$LID)->field(true)->limit(1)->select();
    }

}