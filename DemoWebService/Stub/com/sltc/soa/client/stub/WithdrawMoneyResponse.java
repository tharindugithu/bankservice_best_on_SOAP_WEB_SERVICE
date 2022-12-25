
package com.sltc.soa.client.stub;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="WithdrawMoneyResult" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "withdrawMoneyResult"
})
@XmlRootElement(name = "WithdrawMoneyResponse")
public class WithdrawMoneyResponse {

    @XmlElement(name = "WithdrawMoneyResult")
    protected double withdrawMoneyResult;

    /**
     * Gets the value of the withdrawMoneyResult property.
     * 
     */
    public double getWithdrawMoneyResult() {
        return withdrawMoneyResult;
    }

    /**
     * Sets the value of the withdrawMoneyResult property.
     * 
     */
    public void setWithdrawMoneyResult(double value) {
        this.withdrawMoneyResult = value;
    }

}
